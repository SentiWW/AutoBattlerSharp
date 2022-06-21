namespace AutoBattlerSharp.Logic.Models
{
    public interface IAttackable
    {
        public Attributes Attributes { get; set; }
        public short GetTotalAttack();
        public short GetTotalDefence();
        public FightInfo Attack(IAttackable target, FightInfo info);
    }
}
