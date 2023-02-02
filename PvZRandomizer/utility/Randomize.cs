using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;
using PvZRandomizer.Data;

namespace PvZRandomizer.Utility
{
    static class Randomize
    {
        private readonly static Random rng = new Random();

        // Randomize plant sun costs
        public static void RandomizeSun(List<Plant> plants, string file, string option)
        {

            // "Shuffled" option: Shuffle costs among each other
            if (option == "Shuffled")
            {
                // Create list with sun costs
                List<int> costs = new List<int>();
                foreach (Plant p in plants)
                {
                    costs.Add(p.SunCostData.DefaultValue);
                }
                // Shuffle costs
                costs = costs.OrderBy(a => rng.Next()).ToList();
                // Set new costs
                for (int i = 0; i < plants.Count; i++)
                {
                    plants[i].SunCostData.CurrentValue = costs[i];
                }
            }
            // "Random" option: Randomize costs at multiples of 25 (between 0 and 500)
            else if (option == "Random")
            {
                foreach (Plant p in plants)
                {
                    // Generate random number from 1-20, then multiply by 25
                    p.SunCostData.CurrentValue = rng.Next(21) * 25;
                }
            }
            // "Chaos" option: Randomize costs with no multiples (between 0 and 500)
            else if (option == "Chaos")
            {
                foreach (Plant p in plants)
                {
                    // Generate random number from 0-500
                    p.SunCostData.CurrentValue = rng.Next(501);
                }
            }

            // Edit file byte values
            using (var stream = new FileStream(file, FileMode.Open, FileAccess.ReadWrite))
            {

                // Iterate over plants, checking the new values
                foreach (Plant p in plants)
                {
                    stream.Position = p.SunCostData.DecimalStart;   // Set byte position
                    string hex = Conversion.ConvertIntToHex(p.SunCostData.CurrentValue);    // Convert new value to hex
                    // Write bytes from hex string
                    stream.WriteByte(byte.Parse(hex.Substring(2, 2), NumberStyles.HexNumber));
                    stream.WriteByte(byte.Parse(hex.Substring(0, 2), NumberStyles.HexNumber));
                }

            }

        }

        // Randomize plant recharge rates
        public static void RandomizeRecharge(List<Plant> plants, string file, string option)
        {

            // "Shuffled" option: Shuffle rates among each other
            if (option == "Shuffled")
            {
                // Create list with recharge rates
                List<int> rates = new List<int>();
                foreach (Plant p in plants)
                {
                    rates.Add(p.RechargeRateData.DefaultValue);
                }
                // Shuffle rates
                rates = rates.OrderBy(a => rng.Next()).ToList();
                // Set new rates
                for (int i = 0; i < plants.Count; i++)
                {
                    plants[i].RechargeRateData.CurrentValue = rates[i];
                }
            }
            // "Random" option: Randomize rates at standard values (750, 3000, & 5000)
            else if (option == "Random")
            {
                foreach (Plant p in plants)
                {
                    // Generate random number from 0-2
                    int rateLevel = rng.Next(3);
                    // Set recharge rate based on result
                    if (rateLevel == 0)
                        p.RechargeRateData.CurrentValue = 750;
                    else if (rateLevel == 1)
                        p.RechargeRateData.CurrentValue = 3000;
                    else
                        p.RechargeRateData.CurrentValue = 5000;
                }
            }
            // "Chaos" option: Randomize rates with no multiples (between 0 and 5000)
            else if (option == "Chaos")
            {
                foreach (Plant p in plants)
                {
                    // Generate random number from 0-5000
                    p.RechargeRateData.CurrentValue = rng.Next(5001);
                }
            }

            // Edit file byte values
            using (var stream = new FileStream(file, FileMode.Open, FileAccess.ReadWrite))
            {

                // Iterate over plants, checking the new values
                foreach (Plant p in plants)
                {
                    stream.Position = p.RechargeRateData.DecimalStart;   // Set byte position
                    string hex = Conversion.ConvertIntToHex(p.RechargeRateData.CurrentValue);    // Convert new value to hex
                    // Write bytes from hex string
                    stream.WriteByte(byte.Parse(hex.Substring(2, 2), NumberStyles.HexNumber));
                    stream.WriteByte(byte.Parse(hex.Substring(0, 2), NumberStyles.HexNumber));
                }

            }

        }
    }
}
