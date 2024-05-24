using System;

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
            switch (level)
            {
                case 1:
                    healAmount = 10;
                    break;
                case 2:
                    healAmount = 25;
                    break;
                case 3:
                    healAmount = 50;
                    break;

                default:
                    Console.WriteLine("ERRO 9818241");
                    healAmount = 10;
                    break;
            }
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
            return $"Heal Potion LVL:{level}, (Heals {healAmount}hp)";
        }
    }
}
