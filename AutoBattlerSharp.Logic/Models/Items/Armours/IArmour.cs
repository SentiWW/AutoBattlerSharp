using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBattlerSharp.Logic.Models.Items.Armours
{
    public interface IArmour
    {
        public short DefencePoints { get; set; }

        public short GetDefence(Attributes attributes);
    }
}
