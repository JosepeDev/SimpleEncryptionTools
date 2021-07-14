using System;

public class TypeInBenchmark
{
    /// Represents a type in the benchmark
    /// - Contains the type's name
    /// - Contains a pointer to its benchmark while loop

    public string typeName;
    public Action<int> benchmarkWhileLoop;

    public TypeInBenchmark(string _typeName, Action<int> _BenchmarkWhileLoop)
    {
        typeName = _typeName;
        benchmarkWhileLoop = _BenchmarkWhileLoop;
    }
}
