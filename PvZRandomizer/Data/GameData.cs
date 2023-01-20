using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PvZRandomizer.Data
{
    enum DataType { SunCost, RechargeRate, FiringRate, ProductionRate }

    class GameData
    {
        // Constructor
        public GameData(DataType type, int decStart, int defaultVal, int currentVal)
        {
            Type = type;
            DecimalStart = decStart;
            DefaultValue = defaultVal;
            CurrentValue = currentVal;
        }

        // Properties
        public DataType Type { get; set; }
        public int DecimalStart { get; set; }
        public int DefaultValue { get; set; }
        public int CurrentValue { get; set; }
    }
}
