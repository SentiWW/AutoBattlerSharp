namespace AutoBattlerSharp.Logic.Models.Items.Armours
{
    public interface IArmour
    {
        public short DefencePoints { get; set; }

        public short GetDefence(Attributes attributes);
    }
}
