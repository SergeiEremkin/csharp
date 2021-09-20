using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testfield
{
    class Clock
    {
        public int Hours { get; set; }

        public static implicit operator Clock(int x)
        {
            return new Clock { Hours = x % 24 };
        }

        public static implicit operator int (Clock clock)
        {
            return clock.Hours;
        }
    }
}
