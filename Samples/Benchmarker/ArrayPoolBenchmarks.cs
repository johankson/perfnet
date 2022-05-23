using System.Buffers;
using BenchmarkDotNet.Attributes;
using Proto.Utilities.Benchmark;
namespace Benchmarker;

[MemoryDiagnoser]
[RPlotExporter]
public class ArrayPoolBenchmarks
{
    [GlobalSetup]
    public void GlobalSetup()
    {
        
    }

    [Params(1000)]
    public int Count;

    [Params(1024)]
    public int ArraySize;

    [Benchmark(Baseline = true)]
    public void CreateAndFillArrays()
    {
        for (int i = 0; i < Count; i++)
        {
            var data = new byte[ArraySize];
            for (var index = 0; index < ArraySize; index++)
            {
                data[index] = 42;
            }
        }
    }

    [Benchmark]
    public void UsePooledArrayAndFillIt()
    {
        for (int i = 0; i < Count; i++)
        {
            var data = ArrayPool<byte>.Shared.Rent(ArraySize);
            for (var index = 0; index < ArraySize; index++)
            {
                data[index] = 42;
            }
            ArrayPool<byte>.Shared.Return(data);
        }
    }

    private BenchmarkThreadHelper threadHelper;
    
    [GlobalSetup(Target = nameof(UsePooledArrayAndFillItWithMultipleThreads))]
    public void SetupPooledArrayForMultipleThreads()
    {
        threadHelper = new BenchmarkThreadHelper();
       
        threadHelper.AddAction(Fill);
        threadHelper.AddAction(Fill);
        threadHelper.AddAction(Fill);
        threadHelper.AddAction(Fill);

        void Fill()
        {
            for (int i = 0; i < Count / 4; i++)
            {
                var data = ArrayPool<byte>.Shared.Rent(ArraySize);
                for (var index = 0; index < ArraySize; index++)
                {
                    data[index] = 42;
                }
                ArrayPool<byte>.Shared.Return(data);
            }
        }
    }
    
    [Benchmark]
    public void UsePooledArrayAndFillItWithMultipleThreads()
    {
        threadHelper.ExecuteAndWait();
    }

    [Benchmark]
    public void UsePooledArrayWithBetterFill()
    {
        for (int i = 0; i < Count; i++)
        {
            var data = ArrayPool<byte>.Shared.Rent(ArraySize);
            Array.Fill(data, (byte)42);
            ArrayPool<byte>.Shared.Return(data);
        }
    }
    
    [Benchmark]
    public void CreateNewArrayButFillSmarter()
    {
        for (int i = 0; i < Count; i++)
        {
            var data = new byte[ArraySize];
            Array.Fill(data, (byte)42);
        }
    }
    
    //[Benchmark]
    public async Task UsePooledAndGoCrazyWithTasks()
    {
        var tasks = new List<Task>();
        
        for (var i = 0; i < Count; i++)
        {
            tasks.Add(new Task(Fill));
        }

        await Task.WhenAll(tasks);

        void Fill()
        {
            var data = ArrayPool<byte>.Shared.Rent(ArraySize);
            for (var index = 0; index < ArraySize; index++)
            {
                data[index] = 42;
            }
            ArrayPool<byte>.Shared.Return(data);
        }
    }
}