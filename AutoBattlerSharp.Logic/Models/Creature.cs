using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBattlerSharp.Logic.Models
{
    public abstract class Creature : Entity
    {
        public Attributes Attributes { get; set; }

        public Creature(string name, string description, Attributes attributes) : base(name, description)
        {
            Attributes = attributes;
        }

        public Creature(Creature creature) : base(creature.Name, creature.Description)
        {
            Attributes = new Attributes(creature.Attributes);
        }

        public override string ToString()
        {
            return $"Creature:\n" +
                   $"\tId: {Id}\n" +
                   $"\tName: {Name}\n" +
                   $"\tDescription: {Description}\n" +
                   Attributes.ToString();
        }
    }
}
