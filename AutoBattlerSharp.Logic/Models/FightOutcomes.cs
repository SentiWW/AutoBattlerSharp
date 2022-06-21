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
