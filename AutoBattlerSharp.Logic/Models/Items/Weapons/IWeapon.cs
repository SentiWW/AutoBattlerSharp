namespace AutoBattlerSharp.Logic.Models.Items.Weapons
{
    public interface IWeapon
    {
        public short AttackPoints { get; set; }
        public float Accuracy { get; set; }

        public short GetAttackDamage(Attributes attributes);

    }
}
