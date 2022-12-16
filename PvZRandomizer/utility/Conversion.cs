using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PvZRandomizer.utility
{
    static class Conversion
    {
        // Convert an integer into a hex string
        public static string ConvertIntToHex(int num) => num.ToString("X4");
    }
}
