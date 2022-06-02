using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBattlerSharp.Logic.Models
{
    internal enum FightOutcomes 
    { 
        LessThanZeroDamage,
        ZeroDamage,
        LessThanTenDamage,
        OverOrTenDamage,
        DamageWithBonus,
        KillingBlow,
        AttackedUnattackable,
        AttackedDead,
        Missed,

    }
}
