namespace AutoBattlerSharp.Logic.Models
{
    public abstract class Entity
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;

        public Entity(string name, string description)
        {
            (Id, Name, Description) = (Guid.NewGuid(), name, description);
        }
    }
}