using System;

namespace YetAnotherDungeonCrawler.Models
{
    /// <summary>
    /// This is an Enemy type that has a constructor for instantiation in a room
    /// </summary>
    public class Zombie : Enemy
    {
        private bool bIsDead = false;
        public override bool BIsDead { get { return bIsDead; } set { bIsDead = value; } }
        private int hp;
        public override int HP
        {
            get { return hp; }
            set { hp = value; if (hp <= 0) { hp = 0; BIsDead = true; } }
        }

        private int attackPowerValue;
        public override int AttackPower { get { return attackPowerValue; } set { attackPowerValue = value; } }

        public Zombie(int attackPower, int healthAmount)
        {
            this.HP = healthAmount;
            this.attackPowerValue = attackPower;
        }

        public override string ToString()
        {
            return $"Zombie with {AttackPower} attack power and {HP} HP";
        }
    }
}
