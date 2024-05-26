namespace YetAnotherDungeonCrawler.Models
{
    public abstract class Weapon : ItemBase
    {
        public abstract bool IsEquiped { get; set; }
        public abstract string Equip(bool b);
        public abstract int AttackBuff { get; set; }
    }
}
