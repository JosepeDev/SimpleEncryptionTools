using System;
using System.Collections.Generic;
using System.Text;

public class BenchmarkPresetGroup
{
    private string _name;
    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    public BenchmarkPreset[] presets;

    public BenchmarkPresetGroup(string name, BenchmarkPreset[] benchmarkPresets)
    {
        _name = name;
        presets = benchmarkPresets;
    }

    public BenchmarkPresetGroup(BenchmarkPresetGroup benchmarkPresetGroup) 
        : this(benchmarkPresetGroup.Name, benchmarkPresetGroup.presets) { }
}
