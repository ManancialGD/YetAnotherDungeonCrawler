namespace YetAnotherDungeonCrawler.Models
{
    public class Player
    {
        private int maxHP = 100;
        private int hp;
        public int HP { get { return hp; } private set { hp = value; if (hp < 0) hp = 0; if (hp > maxHP) hp = maxHP; } } // this set will be private only and will make sure that hp will not be less then 0.

        private int attackPower;
        public int AttackPower { get; private set; }

        string name;

        // Constructor
        public Player(string name)
        {
            this.name = name;
            this.hp = maxHP;
            this.attackPower = 10; // Default attack power
        }

        /// <summary>
        /// This Method will be to move player from one room to another
        /// </summary>
        public void Move()
        {
            // Movement logic here
        }

        /// <summary>
        /// This method will be for attacking enemies.
        /// It will receive the Enemy and use the method (Damage) from the Enemy.
        /// </summary>
        public void Attack(Enemy enemy)
        {
            enemy.Damage(attackPower);
        }

        /// <summary>
        /// This Method will take an Item and equip in Player's Inventory
        /// </summary>
        public void PickUpItem(ItemBase item)
        {
            // Logic for picking up and equipping items
        }

        // HP management Methods

        /// <summary>
        /// This Method is to heal the Player.
        /// </summary>
        /// <param name="healAmount"></param>
        public void Heal(int healAmount)
        {
            HP += healAmount;
        }

        /// <summary>
        /// This Method is to damage Player.
        /// </summary>
        /// <param name="damageAmount"></param>
        public void Damage(int damageAmount)
        {
            HP -= damageAmount;
        }
    }
}
