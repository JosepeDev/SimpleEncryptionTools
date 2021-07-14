using System;
using System.Collections.Generic;
using System.Diagnostics;
using static Utilities;
using static TestLibrary;

public static class BenchmarksManager
{
    /// Uses of this class:
    /// - Runs the benchmark and its tests
    /// - Contains the data about the benchmark presets
    /// - Contains the list the of types in the benchmark
    /// - Displays the benchmark results

    static BenchmarkResults currentBenchmarkResults;
    static Stopwatch testsStopWatch;
    static ConsoleKey key_runSameBenchmarkAgain = ConsoleKey.Spacebar;

    #region ResultsText

    static string[] resultsTitle =
        {
            "  _____  ______  _____ _    _ _   _______ _____",
            " |  __ \\|  ____|/ ____| |  | | | |__   __/ ____|",
            " | |__) | |__  | (___ | |  | | |    | | | (___  ",
            " |  _  /|  __|  \\___ \\| |  | | |    | |  \\___ \\",
            " | | \\ \\| |____ ____) | |__| | |____| |  ____) |",
            " |_|  \\_\\______|_____/ \\____/|______|_| |_____/ ",
            ""
        };

    static string[] ResultsDescription
    {
        get
        {
            string[] description =
                {
                string.Format("A comparison between the types {0} and {1}", currentBenchmarkResults.firstTypeName, currentBenchmarkResults.secondTypeName),
                string.Format("Benchmark #{0} of type [{1}]", currentBenchmarkResults.presetNumber, currentBenchmarkResults.presetGroupName)
            };

            return description;
        }
    }

    static string[] ResultsAnalysis
    {
        get
        {
            int higherLength = GetTheHigherLength(currentBenchmarkResults.firstTypeName, currentBenchmarkResults.secondTypeName);
            string firstTypeSpaces = new string(' ', higherLength - currentBenchmarkResults.firstTypeName.Length);
            string secondTypeSpaces = new string(' ', higherLength - currentBenchmarkResults.secondTypeName.Length);
            decimal changesPerSec1 = (decimal)ChangesPerSecond(currentBenchmarkResults.changesAmount, currentBenchmarkResults.firstBenchmarkAverage.TotalSeconds);
            decimal changesPerSec2 = (decimal)ChangesPerSecond(currentBenchmarkResults.changesAmount, currentBenchmarkResults.secondBenchmarkAverage.TotalSeconds);

            string[] afterBenchmarkLines =
            {
                string.Format("{0}" + firstTypeSpaces + "average: {1}", currentBenchmarkResults.firstTypeName, currentBenchmarkResults.firstBenchmarkAverage),
                string.Format("{0}" + secondTypeSpaces + "average: {1}", currentBenchmarkResults.secondTypeName, currentBenchmarkResults.secondBenchmarkAverage),
                " ",
                string.Format("{0}" + firstTypeSpaces + "changes per second: {1}", currentBenchmarkResults.firstTypeName, (long)changesPerSec1),
                string.Format("{0}" + secondTypeSpaces + "changes per second: {1}", currentBenchmarkResults.secondTypeName, (long)changesPerSec2),
                " ",
                string.Format("The type {0} performed better by {1}%", currentBenchmarkResults.BetterTypeName, currentBenchmarkResults.GetHowMuchBetterPercentage())
            };

            return afterBenchmarkLines;
        }
    }

    static string[] resultsBottomText =
    {
        "Press Space to run again the same benchmark",
        "Press any other key to return to the menu",
    };

    #endregion

    #region Types And Comparisons

    static public TypeInBenchmark[] benchmarkTypes =
    {
        new TypeInBenchmark("EncInt", WL_EncInt), // 0
        new TypeInBenchmark("int", WL_Int),
        new TypeInBenchmark("EncLong", WL_EncLong), // 2
        new TypeInBenchmark("long", WL_Long),
        new TypeInBenchmark("EncFloat", WL_EncFloat), // 4
        new TypeInBenchmark("float", WL_Float),
        new TypeInBenchmark("EncDouble", WL_EncDouble), // 6
        new TypeInBenchmark("double", WL_Double),
        new TypeInBenchmark("EncDecimal", WL_EncDecimal), // 8
        new TypeInBenchmark("decimal", WL_Decimal),
        new TypeInBenchmark("EncString", WL_EncString), // 10
        new TypeInBenchmark("string", WL_String),
        new TypeInBenchmark("EncString (0.5.0)", WL_EncString_0_5_0), // 12
        new TypeInBenchmark("EncString (0.7.0)", WL_EncString_0_7_0),
        new TypeInBenchmark("EncInt (0.3.0)", WL_EncInt_0_3_0), // 14
        new TypeInBenchmark("EncInt (0.7.0)", WL_EncInt_0_7_0),
        new TypeInBenchmark("EncInt (0.8.0)", WL_EncInt_0_8_0), // 16
        new TypeInBenchmark("EncDouble (0.5.0)", WL_EncDouble_0_5_0),
        new TypeInBenchmark("EncDouble (0.8.0)", WL_EncDouble_0_8_0), // 18
        new TypeInBenchmark("EncString (0.8.0)", WL_EncString_0_8_0),
        new TypeInBenchmark("EncInt (0.9.0)", WL_EncInt_0_9_0), // 20
        new TypeInBenchmark("EncString (0.9.0)", WL_EncString_0_9_0),
        new TypeInBenchmark("EncLong (0.3.0)", WL_EncLong_0_3_0), // 22
        new TypeInBenchmark("EncLong (0.7.0)", WL_EncLong_0_7_0),
        new TypeInBenchmark("EncLong (0.8.0)", WL_EncLong_0_8_0), // 24
        new TypeInBenchmark("EncLong (0.9.0)", WL_EncLong_0_9_0),
        new TypeInBenchmark("EncDecimal (0.5.0)", WL_EncDecimal_0_5_0), // 26
        new TypeInBenchmark("EncDecimal (0.8.0)", WL_EncDecimal_0_8_0),
        new TypeInBenchmark("EncDecimal (0.9.0)", WL_EncDecimal_0_9_0), // 28
        new TypeInBenchmark("EncDouble (0.9.0)", WL_EncDouble_0_9_0),
        new TypeInBenchmark("EncFloat (0.5.0)", WL_EncFloat_0_5_0), // 30
        new TypeInBenchmark("EncFloat (0.8.0)", WL_EncFloat_0_8_0),
        new TypeInBenchmark("EncFloat (0.9.0)", WL_EncFloat_0_9_0), // 32
        new TypeInBenchmark("EncString (1.1.0)", WL_EncString_1_1_0), 
        new TypeInBenchmark("EncInt (1.1.0)", WL_EncInt_1_1_0), // 34
        new TypeInBenchmark("EncLong (1.1.0)", WL_EncLong_1_1_0),
    };

    static public int[] comparisonsChunks =
    {
        6, 1, 3, 2, 3
    };

    static public BenchmarkData[] comparisons =
    {
        // Enc vs normal
        new BenchmarkData(benchmarkTypes[0], benchmarkTypes[1]),   // int
        new BenchmarkData(benchmarkTypes[2], benchmarkTypes[3]),   // long
        new BenchmarkData(benchmarkTypes[4], benchmarkTypes[5]),   // float
        new BenchmarkData(benchmarkTypes[6], benchmarkTypes[7]),   // double
        new BenchmarkData(benchmarkTypes[8], benchmarkTypes[9]),   // decimal
        new BenchmarkData(benchmarkTypes[10], benchmarkTypes[11]), // string
        
        // Comparing an EncInt with its older versions means nothing
        // Now the EncInt is heavier, because it uses a better, heavier encryption
        // The same thing applies to the EncFloat and EncDouble

        // EncInt
        new BenchmarkData(benchmarkTypes[0], benchmarkTypes[34]),

        // EncLong
        new BenchmarkData(benchmarkTypes[2], benchmarkTypes[22]),
        new BenchmarkData(benchmarkTypes[2], benchmarkTypes[25]),
        new BenchmarkData(benchmarkTypes[2], benchmarkTypes[35]),

        // EncDecimal
        new BenchmarkData(benchmarkTypes[8], benchmarkTypes[26]),
        new BenchmarkData(benchmarkTypes[8], benchmarkTypes[28]),

        // EncString
        new BenchmarkData(benchmarkTypes[10], benchmarkTypes[12]),
        new BenchmarkData(benchmarkTypes[10], benchmarkTypes[21]),
        new BenchmarkData(benchmarkTypes[10], benchmarkTypes[33]),
    };

    #endregion

    #region Benchmark Presets

    static BenchmarkPreset[] benchmarkPresetsFastest =
    {
        new BenchmarkPreset(20, 50000),
        new BenchmarkPreset(100, 10000),
        new BenchmarkPreset(2000, 500),
        new BenchmarkPreset(10, 100000),
    };

    static BenchmarkPreset[] benchmarkPresetsVeryFast =
    {
        new BenchmarkPreset(20, 500000),
        new BenchmarkPreset(100, 100000),
        new BenchmarkPreset(2000, 5000),
        new BenchmarkPreset(10, 1000000),
    };

    static BenchmarkPreset[] benchmarkPresetsFast =
    {
        new BenchmarkPreset(20, 1000000),
        new BenchmarkPreset(100, 200000),
        new BenchmarkPreset(2000, 10000),
        new BenchmarkPreset(10, 2000000),
    };

    static BenchmarkPreset[] benchmarkPresetsNormal =
    {
        new BenchmarkPreset(40, 1000000),
        new BenchmarkPreset(100, 400000),
        new BenchmarkPreset(4000, 10000),
        new BenchmarkPreset(10, 4000000),
    };

    static BenchmarkPreset[] benchmarkPresetsMedium =
    {
        new BenchmarkPreset(40, 2000000),
        new BenchmarkPreset(100, 800000),
        new BenchmarkPreset(4000, 20000),
        new BenchmarkPreset(10, 8000000),
    };

    static BenchmarkPreset[] benchmarkPresetsLong =
    {
        new BenchmarkPreset(40, 4000000),
        new BenchmarkPreset(100, 2000000),
        new BenchmarkPreset(4000, 40000),
        new BenchmarkPreset(10, 20000000),
    };

    static BenchmarkPreset[] benchmarkPresetsVeryLong =
    {
        new BenchmarkPreset(40, 10000000),
        new BenchmarkPreset(100, 5000000),
        new BenchmarkPreset(4000, 100000),
        new BenchmarkPreset(10, 50000000),
    };

    static public BenchmarkPresetGroup[] benchmarkPresetGroups =
    {
        new BenchmarkPresetGroup("Fastest", benchmarkPresetsFastest),
        new BenchmarkPresetGroup("Very Fast", benchmarkPresetsVeryFast),
        new BenchmarkPresetGroup("Fast", benchmarkPresetsFast),
        new BenchmarkPresetGroup("Normal", benchmarkPresetsNormal),
        new BenchmarkPresetGroup("Medium", benchmarkPresetsMedium),
        new BenchmarkPresetGroup("Long", benchmarkPresetsLong),
        new BenchmarkPresetGroup("Very Long", benchmarkPresetsVeryLong),
    };

    #endregion

    #region Methods

    public static void RunBenchmark(BenchmarkData benchmarkData)
    {
        // Prepare benchmark
        Console.Clear();
        currentBenchmarkResults = new BenchmarkResults();
        currentBenchmarkResults.SetData(benchmarkData);

        // Run 2 benchmarks. One for each type
        SeparationLine();
        RunTests(benchmarkData.changesAmount, benchmarkData.testsAmount, benchmarkData.benchmark1);
        SeparationLine();
        RunTests(benchmarkData.changesAmount, benchmarkData.testsAmount, benchmarkData.benchmark2);
        SeparationLine();

        // Finish benchmark
        DisplayResults();
    }

    public static void RunTests(int changesAmount, int testsAmount, Action<int> whileLoop, string varName)
    {
        // Title of type
        WL_Int(2000);
        WriteLine(varName + ":");
        WriteLine();

        // Start measuring time
        List<TimeSpan> timeSpans = new List<TimeSpan>();
        testsStopWatch = new Stopwatch();

        // Run tests
        for (int i = 0; i < testsAmount; i++)
        {
            // Test's title
            WriteLine("Test {0}/{1}: It will make {2} changes in each test.", i + 1, testsAmount, changesAmount);

            // Benchmark
            testsStopWatch.Restart();
            whileLoop(changesAmount);
            testsStopWatch.Stop();

            // After benchmark
            CursorUp();
            PrintTestResults(i + 1, testsAmount, testsStopWatch.Elapsed);
            timeSpans.Add(testsStopWatch.Elapsed);
        }
        
        // Display average and add to the results
        WriteLine();
        TimeSpan average = GetAverage(timeSpans);
        DisplayAverage(average);
        currentBenchmarkResults.SetAverageTimeSpan(average);
    }

    public static void RunTests(int howMuchToIncrement, int testsAmount, TypeInBenchmark benchmark)
    {
        RunTests(howMuchToIncrement, testsAmount, benchmark.benchmarkWhileLoop, benchmark.typeName);
    }

    static void CursorUp()
    {
        ClearCurrentConsoleLine();
        Console.SetCursorPosition(0, Console.CursorTop - 1);
        ClearCurrentConsoleLine();
    }

    static void DisplayResults()
    {
        WriteLines(resultsTitle);
        WriteLines(ResultsDescription);
        SeparationLineSmall();
        WriteLines(ResultsAnalysis);
        SeparationLineSmall();
        WriteLines(resultsBottomText);
        SeparationLine();

        currentBenchmarkResults = null;

        var k = Console.ReadKey();
        if (k.Key == key_runSameBenchmarkAgain)
        {
            RunBenchmark(VarEncBenchmark.currentBenchmarkData);
        }
        else
        {
            VarEncBenchmark.StartProgram();
        }
    }

    static double ChangesPerSecond(int changes, double seconds) => (changes / seconds);

    #endregion
}
