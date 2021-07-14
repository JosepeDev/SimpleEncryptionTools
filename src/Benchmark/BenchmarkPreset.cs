using System;
using System.Collections.Generic;
using System.Text;

public class BenchmarkPreset
{
    private int _testsAmount;

    public int TestsAmount
    {
        get { return _testsAmount; }
        set { _testsAmount = value; }
    }

    private int _changesAmount;

    public int ChangesAmount
    {
        get { return _changesAmount; }
        set { _changesAmount = value; }
    }

    public BenchmarkPreset(int testsAmount, int changesAmount)
    {
        _testsAmount = testsAmount;
        _changesAmount = changesAmount;
    }
}
