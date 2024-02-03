using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YearZeroRandomizer.NET6
{
    public class Dice
    {
        public int Range { get; private set; }
        public int Value { get; private set; }

        public Dice(int range)
        {
            Range = range;
            Value = 0;
        }

        public void Roll()
        {
            Value = Rand.Gen(1, Range);
        }
    }
}
