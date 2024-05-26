using System.Collections.Generic;

namespace YetAnotherDungeonCrawler.Models
{
    public class Player
    {
        private int maxHP = 100;
        private int hp;
        public int HP { get { return hp; } private set { hp = value; if (hp < 0) hp = 0; if (hp > maxHP) hp = maxHP; } }

        private int attackPower;
        public int AttackPower { get; private set; }

        string name;
        public List<ItemBase> Inventory { get; private set; }

        public Player(string name)
        {
            this.name = name;
            this.hp = maxHP;
            this.attackPower = 10;
            this.Inventory = new List<ItemBase>();
        }


        /// <summary>
        /// Will damage the enemy and will add up AttackBuff if the player has a weapon wquipped
        /// </summary>
        /// <param name="enemy"></param>
        /// <returns></returns>
        public string Attack(Enemy enemy)
        {
            int attackBuff = 0;
            foreach (ItemBase item in Inventory)
            {
                if (item is WoodenSword woodenSword)
                {   
                    if (woodenSword.IsEquiped) attackBuff = woodenSword.AttackBuff;
                }
            }
            enemy.Damage(attackPower + attackBuff);
            return $"You attacked the {enemy}.";
        }

        public string PickUpItem(ItemBase item)
        {
            Inventory.Add(item);
            return $"You picked up {item}.";
        }

    /// <summary>
    /// This Method will receive a index and see what type of item it is, if it's a consumable, it will use it
    /// if it is a weapon, will equip if not equipped or unequip if equipped
    /// </summary>
    /// <param name="index"></param>
    /// <returns></returns>
    public string InteractWithItem(int index)
    {
        if (index >= 0 && index < Inventory.Count)
        {
            string result = "Item Unknown";
            ItemBase item = Inventory[index];
            if (item is HealPotion healPotion)
            {
                result = healPotion.Use(this);
                Inventory.RemoveAt(index);
            }
            else if (item is WoodenSword woodenSword)
            {
                foreach (ItemBase currentItem in Inventory)
                {
                    if (currentItem is Weapon weapon) // if it's a weapon, enequip
                    {
                        weapon.Equip(false);
                    }
                }
                // if not equipped, equip
                if (!woodenSword.IsEquiped)
                {
                    result = woodenSword.Equip(true);
                }
                // if already equipped, unequip
                else
                {
                    result = woodenSword.Equip(false);
                }
            }
            return result;
        }
        else
        {
            return "Invalid item index.";
        }
    }


        /// <summary>
        /// Simple Heal method
        /// </summary>
        /// <param name="healAmount"></param>
        public void Heal(int healAmount)
        {
            HP += healAmount;
        }

        /// <summary>
        /// Simple Damage Method
        /// </summary>
        /// <param name="damageAmount"></param>
        public void Damage(int damageAmount)
        {
            HP -= damageAmount;
        }
    }
}
