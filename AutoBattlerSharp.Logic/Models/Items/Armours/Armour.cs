﻿using System.Text.Json.Serialization;

namespace AutoBattlerSharp.Logic.Models.Items.Armours
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
