using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBattlerSharp.Logic.Models
{
    internal class Human : Creature
    {
        public Human(string name, string description, Attributes attributes) : base(name, description, attributes)
        {

        }
    }
}
