using BenchmarkDotNet.Running;
using ObjectMapping;
class Program
{
    static void Main(string[] args)
    {
        BenchmarkRunner.Run<MappersBenchmark>();
    }
}
