using System;

namespace YetAnotherDungeonCrawler.Models
{
    public class HealPotion : Consumable
    {
        private int level;
        public override int Level { get { return level; } set { level = value; } }
        private int healAmount;
        public HealPotion(int level)
        {
            Level = level;
            healAmount = 50 + (15 * (level - 1));
        }

        public override string Use(Player player)
        {
            player.Heal(healAmount);
            return "Heal Potion used";
        }

        public override string ToString()
        {
            return $"Heal Potion LVL:{level}, (Heals {healAmount}hp)";
        }
    }
}
