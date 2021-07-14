using System;
using System.Collections.Generic;
using System.Text;

public class BenchmarkResults
{
    /// A class for containing benchmark result
    /// Used in the benchmark manager

    public string firstTypeName;
    public string secondTypeName;

    public int changesAmount;

    public string presetGroupName;
    public int presetNumber;

    public TimeSpan firstBenchmarkAverage = TimeSpan.Zero;
    public TimeSpan secondBenchmarkAverage = TimeSpan.Zero;

    #region Properties

    public bool BetterTypeIsFirst
    {
        get => (firstBenchmarkAverage < secondBenchmarkAverage);
    }

    public string BetterTypeName
    {
        get => (BetterTypeIsFirst) ? firstTypeName : secondTypeName;
    }

    public string WorseTypeName
    {
        get => (!BetterTypeIsFirst) ? firstTypeName : secondTypeName;
    }

    public TimeSpan BetterTypeAverage
    {
        get => (BetterTypeIsFirst) ? firstBenchmarkAverage : secondBenchmarkAverage;
    }

    public TimeSpan WorseTypeAverage
    {
        get => (!BetterTypeIsFirst) ? firstBenchmarkAverage : secondBenchmarkAverage;
    }

    #endregion

    #region Methods

    public void SetData(BenchmarkData benchmarkData)
    {
        firstTypeName = benchmarkData.benchmark1.typeName;
        secondTypeName = benchmarkData.benchmark2.typeName;
        presetGroupName = benchmarkData.benchmarkPresetGroupName;
        presetNumber = benchmarkData.benchmarkPresetNumber;
        changesAmount = benchmarkData.changesAmount;
    }

    public void SetAverageTimeSpan(TimeSpan timeSpan)
    {
        if (firstBenchmarkAverage == TimeSpan.Zero)
        {
            firstBenchmarkAverage = timeSpan;
        }
        else
        {
            secondBenchmarkAverage = timeSpan;
        }
    }

    public float GetHowMuchBetterPercentage()
    {
        TimeSpan betterTimeSpan = BetterTypeAverage;
        TimeSpan worseTimeSpan = WorseTypeAverage;

        long betterInTicks = betterTimeSpan.Ticks;
        long worseInTicks = worseTimeSpan.Ticks;

        double whatIsLeft = (double)(worseInTicks - betterInTicks);

        double onePercent = betterInTicks / 100;
        return (float)(whatIsLeft / onePercent);
    }

    #endregion
}
