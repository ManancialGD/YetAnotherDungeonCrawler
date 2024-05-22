using System;

namespace YetAnotherDungeonCrawler.Models
{
    /// <summary>
    /// Since we can have multiple types of enemy, this class will be abstract to create others from it.
    /// </summary>
    abstract class Enemy
    {
        // Health related variables
        public abstract int HP { get; set; }

        // Attacks
        public abstract int AttackPower { get; set; }

        // Type of enemy
        public abstract string EnemyType { get; set; }

        // Bools
        public abstract bool BIsDead { get; set; }

        public void Damage(int damageAmount)
        {
            HP -= damageAmount;
        }

        public void Attack(Player player)
        {
            player.Damage(AttackPower);
        }
    }
}
