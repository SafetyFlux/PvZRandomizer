using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PvZRandomizer.Data
{
    class Plant
    {
        // Constructor
        public Plant(string name, string packetID, bool enabled)
        {
            Name = name;
            SeedPacketID = packetID;
            Enabled = enabled;
            DataList = new List<GameData>();
        }

        // Properties
        public string Name { get; set; }                // The plant's name
        public string SeedPacketID { get; set; }        // The plant's seed packet ID (2-digit hex value)
        public bool Enabled { get; set; }               // Whether randomizing the plant is enabled [NOT IMPLEMENTED]
        public List<GameData> DataList { get; set; }    // A list of the plant's data values
    }
}
