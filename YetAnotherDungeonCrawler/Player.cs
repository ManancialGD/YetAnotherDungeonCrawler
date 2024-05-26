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

        public string Attack(Enemy enemy)
        {
            int attackBuff = 0;
            foreach (ItemBase item in Inventory)
            {
                if (item is WoodenSword woodenSword)
                {
                    attackBuff = woodenSword.AttackBuff;
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
                    if (currentItem is Weapon weapon)
                    {
                        weapon.Equip(false);
                    }
                }
                if (!woodenSword.IsEquiped)
                {
                    result = woodenSword.Equip(true);
                }
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



        public void Heal(int healAmount)
        {
            HP += healAmount;
        }

        public void Damage(int damageAmount)
        {
            HP -= damageAmount;
        }
    }
}
