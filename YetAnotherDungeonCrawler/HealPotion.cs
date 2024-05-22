namespace YetAnotherDungeonCrawler.Models
{
    class HealPotion : ItemBase
    {
        private string itemType = "HealPotion";
        public override string ItemType { get { return itemType; } set { itemType = value; } }

        private int healAmount;

        public HealPotion(int healAmount)
        {
            this.healAmount = healAmount;
        }

        public override void Use(Player player)
        {
            player.Heal(healAmount);
        }

        public override void Equip()
        {
            // No implementation for Equip in HealPotion
        }

        public override string ToString()
        {
            return $"{ItemType} (Heals for {healAmount})";
        }
    }
}
