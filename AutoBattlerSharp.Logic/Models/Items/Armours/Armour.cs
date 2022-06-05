using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AutoBattlerSharp.Logic.Models.Items
{
    public class Armour : Item, IArmour
    {
        [JsonPropertyName("defencepoints")]
        [JsonInclude]
        public short DefencePoints { get; set; }

        [JsonConstructor]
        public Armour()
        {

        }

        public Armour (string name, string description, short value, short weight, short defencePoints) 
            : base(name, description, value, weight)
        {
            DefencePoints = defencePoints;
        }

        public short GetDefence(Attributes attributes)
        {
            return DefencePoints;
        }
    }
}
