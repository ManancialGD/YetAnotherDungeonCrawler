namespace YetAnotherDungeonCrawler.Models
{
    public class WoodenSword : Weapon
    {
        public override bool IsEquiped { get; set; }
        private int level;
        public override int Level { get { return level; } set { level = value; } }

        private int attackBuff;
        public override int AttackBuff { get { return attackBuff; } set { attackBuff = value; } }


        public WoodenSword(int level)
        {
            this.level = level;
            attackBuff = level * 10;
        }

        // Method to equip the sword
        public override string Equip(bool b)
        {
            IsEquiped = b;

            if (IsEquiped)
            {
                return $"Wooden sword Level:{Level} equipped";
            }
            else if (!IsEquiped) return $"Wooden sword Level:{Level} unequipped";
            return "";
        }
        public override string ToString()
        {
            return $"Wooden Sword LVL:{Level}, (AttackBuff of {AttackBuff})";
        }
    }
}
