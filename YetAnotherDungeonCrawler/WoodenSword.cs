namespace YetAnotherDungeonCrawler.Models
{
    public class WoodenSword : Weapon
    {
        public override bool IsEquiped { get; set; }
        private int level;
        public override int Level { get { return Level; } set { level = value; } }

        private int attackBuff;
        public override int AttackBuff { get { return attackBuff; } set { attackBuff = value; }}


        public WoodenSword(int level)
        {
            attackBuff = level * 10;
        }

        // Method to equip the sword
        public override string Equip(bool b)
        {
            IsEquiped = b;

            if (IsEquiped) return "Item is equipped";
            else return "Item unequipped";
        }
        public override string ToString()
        {
            return $"Heal Potion LVL:{Level}, (AttackBuff of {AttackBuff})";
        }
    }
}
