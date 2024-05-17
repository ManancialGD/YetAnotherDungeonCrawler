namespace YetAnotherDungeonCrawler
{
    /// <summary>
    /// Since we can have multiple types of enemy, this class will be abstract to create others from it.
    /// </summary>
    abstract class Enemy
    {
        // Health related variables
        private int hp;
        public int HP { get { return hp; } private set { hp = value; } }

        // Attacks
        private int attackPower;

        // Type of enemy
        private string type;
        
        // Bools
        private bool bIsDead = false;
        public bool BIsDead { get { return bIsDead; } private set { bIsDead = value; } }

        public void Damage( int damageAmount )
        {
            HP -= damageAmount;
            if (hp <= 0)
            {
                BIsDead = true;
            }
        }
        public void Attack(Player player)
        {
            player.Damage(attackPower);
        }

    }
}