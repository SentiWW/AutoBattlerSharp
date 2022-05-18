using System.Text.Json.Serialization;

namespace AutoBattlerSharp.Logic.Models.Items
{
    public class Item : Entity
    {
        [JsonPropertyName("value")]
        [JsonInclude]
        public short Value { get; set; }
        [JsonPropertyName("weight")]
        [JsonInclude]
        public short Weight { get; set; }

        [JsonConstructor]
        public Item()
        {

        }

        public Item(string name, string description, short value, short weight) 
            : base(name, description)
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
                   $"\tValue: {Value}\n" +
                   $"\tWeight: {Weight}\n";
        }
    }
}
