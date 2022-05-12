using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBattlerSharp.Logic.Models
{
    internal abstract class Creature : Entity
    {
        Attributes Attributes { get; set; }

        public Creature(string name, string description, Attributes attributes) : base(name, description)
        {
            Attributes = attributes;
        }
    }
}
