using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PvZRandomizer.utility
{
    static class Randomize
    {
        // Randomize plant sun costs
        public static void RandomizeSun(int min, int max, int incr)
        {
            // Define starting index
            int startIndex = 5033770;

            // Set defaults if any invalid data exists
            if (min < 0 || min > max)
                min = 0;
            if (max < 0 || max > 5000)
                max = 500;
            if (incr > max - min || incr < 1)
                incr = 1;

            // Edit file byte values
            using (var stream = new FileStream("input/PlantsVsZombies.exe", 
                FileMode.Open, FileAccess.ReadWrite))
            {
                
            }
        }
    }
}
