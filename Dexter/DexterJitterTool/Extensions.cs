using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DexterJitterTool
{
    public static class Extensions
    {
        public static double StdDev(this List<int> values)
        {
            if (!values.Any()) return 0;

            var average = values.Average();
            var sum = values.Sum(v => (v - average) * (v - average));
            return Math.Sqrt(sum / (values.Count - 1));
        }
    }
}
