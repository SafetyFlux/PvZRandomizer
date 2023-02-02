using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PvZRandomizer.Data
{
    class Plant
    {
        // Properties
        public bool Enabled { get; set; }               // Whether randomizing the plant is enabled [NOT IMPLEMENTED]
        public string SeedPacketID { get; set; }        // The plant's seed packet ID (2-digit hex value)
        public string EnglishName { get; set; }         // The plant's name
        public SunCostData SunCost { get; set; }
        public RechargeRateData RechargeRate { get; set; }

        // Overridden ToString method
        public override string ToString()
        {
            return $"{SeedPacketID} - {EnglishName}";
        }
    }
}
