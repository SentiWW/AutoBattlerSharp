namespace AutoBattlerSharp.Logic.Models
{
    public abstract class Item : Entity
    {
        public short Value { get; set; }
        public short Weight { get; set; }

        public Item(string name, string description, short value, short weight) : base(name, description)
        {
            Value = value;
            Weight = weight;
        }

        public override string ToString()
        {
            return $"Item:\n" +
                   $"\tId: {Id}\n" +
                   $"\tName: {Name}\n" +
                   $"\tDescription: {Description}\n" +
                   $"Value: {Value}\n" +
                   $"Weight: {Weight}\n";
        }
    }
}
