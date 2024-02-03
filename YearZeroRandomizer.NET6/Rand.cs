using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YearZeroRandomizer.NET6
{
    public static class Rand
    {
        public static Random random = new();
        public static int Gen(int minValue, int maxValue)
        {
            return random.Next(minValue, maxValue + 1);
        }
    }
}
