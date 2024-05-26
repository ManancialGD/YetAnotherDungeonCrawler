using System;

namespace YetAnotherDungeonCrawler.Models
{
    public abstract class Enemy
    {
        public abstract int HP { get; set; }
        public abstract int AttackPower { get; set; }
        public abstract bool BIsDead { get; set; }

        public void Damage(int damageAmount)
        {
            HP -= damageAmount;
        }

        public string Attack(Player player)
        {
            player.Damage(AttackPower);
            return $"The enemy attacked you for {AttackPower} damage.";
        }
    }
}
