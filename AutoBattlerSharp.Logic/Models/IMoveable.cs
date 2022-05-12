using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBattlerSharp.Logic.Models
{
    internal interface IMoveable
    {
        public byte Position { get; set; }
        public void Move(byte position);
    }
}
