namespace AutoBattlerSharp.Logic.Models
{
    public abstract class Item : Entity
    {
        public byte Value { get; set; }
        public byte Weight { get; set; }

        public Item(string name, string description, byte value, byte weight) : base(name, description)
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
