using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;

namespace PvZRandomizer.utility
{
    static class Randomize
    {
        private static Random rand = new Random();

        // Randomize plant sun costs
        public static void RandomizeSun(string file, decimal min, decimal max, decimal incr)
        {
            // Set defaults if any invalid data exists
            if (min < 0 || min > max)
                min = 0;
            if (max < 0 || max > 5000)
                max = 500;
            if (incr > max - min || incr < 1)
                incr = 1;

            // Change minimum and maximum values based on increment for RNG
            min = Math.Floor(min / incr);
            max = Math.Floor(max / incr);

            // Edit file byte values
            using (var stream = new FileStream(file, FileMode.Open, FileAccess.ReadWrite))
            {
                // Define starting index
                stream.Position = 5033770;

                for (int i = 0; i < 49; i++)
                {
                    int num = (int)(rand.Next((int)min, (int)max + 1) * incr);
                    string hex = Conversion.ConvertIntToHex(num);

                    stream.WriteByte(byte.Parse(hex.Substring(2, 2), NumberStyles.HexNumber));
                    stream.WriteByte(byte.Parse(hex.Substring(0, 2), NumberStyles.HexNumber));

                    stream.Position += 34;
                }
            }
        }
    }
}
