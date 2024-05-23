namespace YetAnotherDungeonCrawler.Models
{
    class HealPotion : ItemBase
    {
        private bool isEquiped;
        public override bool IsEquiped { get { return isEquiped; } set { isEquiped = value; } }
        private int level;
        private int healAmount;
        public HealPotion(int level)
        {
            this.level = level;
            healAmount = level * 10;
        }

        public override string Use(Player player)
        {
            if (!IsEquiped) return "You need to equipe the item first.";
            player.Heal(healAmount);
            return "Heal Potion used";
        }

        public override void Equip()
        {
            // No implementation for Equip in HealPotion
        }

        public override string ToString()
        {
            return $"Heal Potion, (Heals for {healAmount})";
        }
    }
}
