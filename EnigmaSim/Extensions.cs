using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnigmaSim
{
    static class Extensions
    {
        public static int Mod(this int i, int d)
        {
            int r = i % d;
            return r < 0 ? r + d : r;
        }
    }
}
