using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLExamples.Examples
{
    public class BoxingDemonstration
    {
        [Benchmark]
        public void IntegerBoxing() {
            int i = int.MaxValue;

            object o = i;
        }

        [Benchmark]
        public void IntegerUnboxing() {
            object o = int.MaxValue;

            int i = (int)o;
        }
    }
}
