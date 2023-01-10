using BenchmarkDotNet.Running;
using CLExamples.Examples;

namespace CLExamples
{
    internal class Program
    {
        static void Main(string[] args) {
            //var summary = BenchmarkRunner.Run(typeof(Program).Assembly);
            NumberTypeExamples.ByteExamples();
            NumberTypeExamples.OtherIntegerExamples();
        }
    }
}