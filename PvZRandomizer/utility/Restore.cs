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
    static class Restore
    {
        public static void RestoreGame(List<Plant> plants, string file)
        {
            // Edit file byte values
            using (var stream = new FileStream(file, FileMode.Open, FileAccess.ReadWrite))
            {

                // Iterate over plants, checking the default values
                foreach (Plant p in plants)
                {
                    // Restore default sun cost
                    stream.Position = p.SunCostData.DecimalStart;
                    string hex = Conversion.ConvertIntToHex(p.SunCostData.DefaultValue);
                    stream.WriteByte(byte.Parse(hex.Substring(2, 2), NumberStyles.HexNumber));
                    stream.WriteByte(byte.Parse(hex.Substring(0, 2), NumberStyles.HexNumber));
                    p.SunCostData.CurrentValue = p.SunCostData.DefaultValue;    // Set current value to default
                    // Restore default recharge rate
                    stream.Position = p.RechargeRateData.DecimalStart;
                    hex = Conversion.ConvertIntToHex(p.RechargeRateData.DefaultValue);
                    stream.WriteByte(byte.Parse(hex.Substring(2, 2), NumberStyles.HexNumber));
                    stream.WriteByte(byte.Parse(hex.Substring(0, 2), NumberStyles.HexNumber));
                    p.RechargeRateData.CurrentValue = p.RechargeRateData.DefaultValue;  // Set current value to default
                }

            }
        }
    }
}
