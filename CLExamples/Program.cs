using BenchmarkDotNet.Running;
using CLExamples.Examples;

namespace CLExamples
{
    internal class Program
    {
        static void Main(string[] args) {
            //var summary = BenchmarkRunner.Run(typeof(Program).Assembly);
            // NumberTypeExamples.ByteExamples();
            // NumberTypeExamples.OtherIntegerExamples();

            Console.WriteLine("Value Type Reassignment");
            ValueAndReferenceTypeExamples.ValueTypeReassignment();

            Console.WriteLine("\nString Type Reassignment");
            ValueAndReferenceTypeExamples.StringTypeReassignment();

            Console.WriteLine("\nReference Type Reassignment");
            ValueAndReferenceTypeExamples.ReferenceTypeReassignment();

            // UserDefinedTypesExamples.ChangingValueTypes();
            // UserDefinedTypesExamples.ChangingReferenceTypes();
        }
    }
}