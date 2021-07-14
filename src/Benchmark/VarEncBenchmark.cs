using System;
using System.Collections.Generic;
using static Utilities;

static class VarEncBenchmark
{
    /// The main class of the application
    /// - Displays the menu and its sections
    /// - Contains the content of each section in the menu
    /// - Manage input from the user and use it

    static ChoosingState currentSection;
    public static BenchmarkData currentBenchmarkData;
    static BenchmarkPresetGroup currentBenchmarkPresetGroup;

    static string currentVersion = "1.2.0";
    static string titleOfApplication = "VarEnc's Benchmarking Console Application";
    static private string choiceText = "Type the number of your choice and press ENTER";

    public static void StartProgram()
    {
        // Setup console application
        Console.Title = titleOfApplication;

        // Set currunt section
        currentSection = ChoosingState.ChoosingComparisons;

        // Print first menu section
        PrintSection();
    }

    #region Sections Content

    static void PrintSectionTitle()
    {
        switch (currentSection)
        {
            case ChoosingState.ChoosingComparisons:
                WriteLine("Step #1: TYPES TO COMPARE");
                break;

            case ChoosingState.ChoosingDuration:
                WriteLine("Step #2: BENCHMARK DURATION");
                break;

            case ChoosingState.ChoosingPreset:
                WriteLine("Step #3: BENCHMARK PRESET");
                break;

            default:
                break;
        }
    }

    static void PrintSectionText()
    {
        string[] textToReturn;

        // Only if there's an existing benchmark preset that can be used,
        // display the option to run the previous benchmark.
        string previousBenchmarkText =
            (currentBenchmarkData == null || !currentBenchmarkData.IsValid)
            ? ""
            : "\n  - Type the letter \"p\" or the word \"prev\" to run again the previous benchmark.";

        switch (currentSection)
        {
            case ChoosingState.ChoosingComparisons:
                string[] text1 =
                {
                        "- Current version - " + currentVersion,
                        "- Welcome to the console app for speedtesting the VarEnc features.",
                        "- If you already know the numbers of your choices, you can input them all together. (separated with spaces)",
                        "- Type the letter \"s\" or the word \"size\" to see the size of each type in bytes." + previousBenchmarkText,
                        "- These are the types you can compare:"
                    };
                textToReturn = text1;
                break;

            case ChoosingState.ChoosingDuration:
                string[] text2 =
                {
                        string.Format("You chose to compare the types {0} and {1}", currentBenchmarkData.benchmark1.typeName, currentBenchmarkData.benchmark2.typeName),
                        "Now choose how long you want the benchmark to be.",
                    };
                textToReturn = text2;
                break;

            case ChoosingState.ChoosingPreset:
                string[] text3 =
                {
                        string.Format("You chose to compare the types {0} and {1}", currentBenchmarkData.benchmark1.typeName, currentBenchmarkData.benchmark2.typeName),
                        string.Format("You chose to perform a benchmark of type {0}", currentBenchmarkPresetGroup.Name),
                        "When running, the benchmark will perform a certain amount tests for the variable types you chose.",
                        "and in each test, the application will perform changes to these variables a certain amount of time."
                    };
                textToReturn = text3;
                break;

            default:
                textToReturn = null;
                break;
        }

        if (textToReturn != null) WriteLines(textToReturn);
    }

    static void PrintSectionChoicesList()
    {
        switch (currentSection)
        {
            case ChoosingState.ChoosingComparisons:
                PrintComparisonsList();
                break;

            case ChoosingState.ChoosingDuration:
                PrintBenchmarkPresetGroupList();
                break;

            case ChoosingState.ChoosingPreset:
                PrintBenchmarkPresetGroup();
                break;

            default:
                break;
        }
    }

    // Section #1
    public static void PrintComparisonsList()
    {
        // number in list of choices 
        int number = 0;

        // foreach chunk
        for (int i1 = 0; i1 < BenchmarksManager.comparisonsChunks.Length; i1++)
        {
            // print chunk content
            for (int i2 = 0; i2 < BenchmarksManager.comparisonsChunks[i1]; i2++)
            {
                // measure spacing
                int firstTypeLength = BenchmarksManager.comparisons[number].benchmark1.typeName.Length;
                string spaces1 = new string(' ', 3 - HowManyDigits(number + 1));
                string spaces2 = new string(' ', GetSpacesLength() - firstTypeLength);

                // construct line
                string line = string.Format(
                        "{0}." + spaces1 + "{1}" + spaces2 + "vs {2}",
                        number + 1, BenchmarksManager.comparisons[number].benchmark1.typeName,
                        BenchmarksManager.comparisons[number].benchmark2.typeName);

                // print line and increase number
                WriteLine(line);
                number++;
            }

            // if it is the last option in the chunk, print an empty line and continue to the next chunk
            if (i1 < BenchmarksManager.comparisonsChunks.Length - 1)
            {
                WriteLine();
            }
        }
    }

    // Section #2
    public static void PrintBenchmarkPresetGroupList()
    {
        for (int i = 0; i < BenchmarksManager.benchmarkPresetGroups.Length; i++)
        {
            int number = i + 1;
            string spaces = new string(' ', 5 - HowManyDigits(number));
            WriteLine("{0}." + spaces + "{1}", number, BenchmarksManager.benchmarkPresetGroups[i].Name);
        }
    }

    // Section #3
    public static void PrintBenchmarkPresetGroup()
    {
        BenchmarkPresetGroup group = currentBenchmarkPresetGroup;
        WriteLine("These are the {0} benchmark presets:", group.Name);
        for (int i = 0; i < group.presets.Length; i++)
        {
            int number = i + 1;
            int changesAmount =
                (currentBenchmarkData.ComparingStrings)
                ? group.presets[i].ChangesAmount / 50
                : group.presets[i].ChangesAmount;

            string[] lines =
            {
                "",
                string.Format("PRESET #{0}:", number),
                string.Format("-{0} Tests", group.presets[i].TestsAmount),
                string.Format("-{0} Changes", changesAmount)
            };
            WriteLines(lines);
        }
    }


    // Special Section -  input "s" in the menu
    public static void PrintSizesOfTypes()
    {
        Console.Clear();

        SeparationLine();
        WriteLine("These are the sizes of each type, in bytes.");
        SeparationLineSmall();

        WriteLine("int        size: {0}", 4);
        WriteLine("EncInt     size: {0}", 8);
        WriteLine();
        WriteLine("long       size: {0}", 8);
        WriteLine("EncLong    size: {0}", 16);
        WriteLine();
        WriteLine("float      size: {0}", 4);
        WriteLine("EncFloat   size: {0}", 8);
        WriteLine();
        WriteLine("double     size: {0}", 8);
        WriteLine("EncDouble  size: {0}", 16);
        WriteLine();
        WriteLine("decimal    size: {0}", 16);
        WriteLine("EncDecimal size: {0}", 32);

        SeparationLineSmall();
        WriteLine("Press any to return to the menu");
        SeparationLine();
        Console.ReadKey();
        StartProgram();
    }

    public static void PrintSection()
    {
        // clear previous text
        Console.Clear();

        // section's description
        SeparationLine();
        PrintSectionText();

        // section's title
        SeparationLineSmall();
        PrintSectionTitle();
        SeparationLineSmall();

        // section's list of choices
        PrintSectionChoicesList();
        SeparationLineSmall();
        WriteLine(choiceText);
        SeparationLine();

        // get input for next section
        GetInput();
    }

    public static int GetSpacesLength()
    {
        int highest = 0;
        for (int i = 0; i < BenchmarksManager.comparisons.Length; i++)
        {
            int current = BenchmarksManager.comparisons[i].benchmark1.typeName.Length;
            if (current > highest) highest = current;
        }
        return highest + 1;
    }

    #endregion

    #region Input

    public static bool IsNumberValid(int num)
    {
        int max;

        switch (currentSection)
        {
            case ChoosingState.ChoosingComparisons:
                max = BenchmarksManager.comparisons.Length;
                break;

            case ChoosingState.ChoosingDuration:
                max = BenchmarksManager.benchmarkPresetGroups.Length;
                break;

            case ChoosingState.ChoosingPreset:
                max = currentBenchmarkPresetGroup.presets.Length;
                break;

            default:
                max = 0;
                break;
        }

        return (num != 0 && num <= max);
    }

    public static void GetInput()
    {
        // save input from user
        var line = Console.ReadLine();

        if (String.IsNullOrWhiteSpace(line))
        {
            ActiveError("Empty input");
        }

        // input for seeing the sizes of the types
        else if (currentSection == ChoosingState.ChoosingComparisons && line.Contains("s"))
        {
            PrintSizesOfTypes();
        }

        // input for running the previous benchmark
        else if (currentSection == ChoosingState.ChoosingComparisons && line.Contains("p") && currentBenchmarkData != null && currentBenchmarkData.IsValid)
        {
            BenchmarksManager.RunBenchmark(currentBenchmarkData);
        }
        else // normal choosing input
        {
            // if there are spaces, it means the user inputed many choices separated with spaces
            if (line.Contains(" ") && ContainingDigits(line))
            {
                ApplyMultipleInputs(line);
            }
            else
            {
                ApplySingleInput(line);
            }
        }
    }

    public static void ApplyMultipleInputs(string inputs)
    {
        string[] entries = inputs.Split(' ');
        List<int> e = new List<int>();

        for (int i = 0; i < entries.Length; i++)
        {
            if (ContainingOnlyDigits(entries[i]))
            {
                e.Add(int.Parse(entries[i]));
            }
        }

        for (int i = 0; i < e.Count; i++)
        {
            bool choosing = (i + 1 == e.Count) ? true : false;
            AddDataFromInput(e[i], choosing);
        }
    }

    public static void ApplySingleInput(string input)
    {
        if (ContainingOnlyDigits(input))
        {
            int inputNum = int.Parse(input);
            AddDataFromInput(inputNum);
        }
        else
        {
            ActiveError("Invalid input");
        }
    }

    public static void AddDataFromInput(int input, bool printAfter = true)
    {
        // Adds the data by the user's input
        // Prints the next section
        // Or starts the benchmark if it is the last section

        if (IsNumberValid(input))
        {
            int inputForArray = input - 1;
            switch (currentSection)
            {
                case ChoosingState.ChoosingComparisons:
                    currentBenchmarkData = new BenchmarkData(BenchmarksManager.comparisons[inputForArray]);
                    currentSection = ChoosingState.ChoosingDuration;
                    if (printAfter) PrintSection();
                    break;

                case ChoosingState.ChoosingDuration:
                    currentBenchmarkPresetGroup = BenchmarksManager.benchmarkPresetGroups[inputForArray];
                    currentSection = ChoosingState.ChoosingPreset;
                    if (printAfter) PrintSection();
                    break;

                case ChoosingState.ChoosingPreset:
                    currentSection = ChoosingState.Complete;
                    currentBenchmarkData.InputPreset(currentBenchmarkPresetGroup.presets[inputForArray], currentBenchmarkPresetGroup.Name, input);
                    BenchmarksManager.RunBenchmark(currentBenchmarkData);
                    break;

                default:
                    break;
            }
        }

        else
        {
            ActiveError("Number is invalid. Number: <" + input + ">");
        }
    }

    #endregion
}
