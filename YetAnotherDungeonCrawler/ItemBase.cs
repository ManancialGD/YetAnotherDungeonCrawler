namespace YetAnotherDungeonCrawler
{
    /// <summary>
    /// This class will be a base for other items
    /// </summary>
    abstract class ItemBase
    {
        // Variables
        private string itemType;
        public string ItemType { get; private set;}

        // Methods
        public abstract void Use();
        public abstract void PickUp();
    }
}