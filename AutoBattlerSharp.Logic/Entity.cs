namespace AutoBattlerSharp.Logic
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class Entity
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    }
}