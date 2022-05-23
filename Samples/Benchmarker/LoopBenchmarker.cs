using BenchmarkDotNet.Attributes;
using Examples;
[MemoryDiagnoser]
// [SimpleJob(RuntimeMoniker.Net50)]
// [SimpleJob(RuntimeMoniker.Net60)]
[RPlotExporter]
public class LoopBenchmarker
{
    private readonly Collections collection = new();

    // [Params(true, false)]
    public bool LargeDucks = false;

    // [Params(true, false)]
    public bool EmbeddedInJunk = false;

    // [Params(100, 1000, 10000, 100000)]
    public int DuckCount = 1000;
    
    [GlobalSetup]
    public void GlobalSetup()
    {
        collection.Generate(DuckCount, LargeDucks, EmbeddedInJunk);
        Console.WriteLine($"ducks! {DuckCount}, {LargeDucks}, {EmbeddedInJunk}");
    }
    
    [Benchmark(Baseline = true)]
    public void LinqSum()
    {
        var sum = collection.Ducks.Sum(d => d.Age);
    }

    [Benchmark]
    public void ForEachLoop()
    {
        var sum = 0;
        foreach (var duck in collection.Ducks)
        {
            sum += duck.Age;
        }
    }
    
    [Benchmark]
    public void ForLoop()
    {
        var sum = 0;
            
        for (var index = 0; index < collection.Ducks.Count; index++)
        {
            var duck = collection.Ducks[index];
            sum += duck.Age;
        }
    }
    
    [Benchmark]
    public void IEnumerableLoop()
    {
        var sum = 0;
            
        var enumerable = collection.Ducks as IEnumerable<Duck>;
        foreach (var duck in enumerable)
        {
            sum += duck.Age;
        }
    }

}