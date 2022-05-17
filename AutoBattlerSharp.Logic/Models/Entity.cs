using System.Text.Json.Serialization;

namespace AutoBattlerSharp.Logic.Models
{
    public abstract class Entity
    {
        protected static Random _random = new Random();
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;

        [JsonConstructor]
        public Entity()
        {

        }

        public Entity(string name, string description)
        {
            (Id, Name, Description) = (Guid.NewGuid(), name.Trim(), description);
        }

        public override string ToString()
        {
            return $"Entity:\n" +
                   $"\tId: {Id}\n" +
                   $"\tName: {Name}\n" +
                   $"\tDescription: {Description}";
        }
    }
}