namespace YetAnotherDungeonCrawler
{
    /// <summary>
    /// This is an Enemy type that has a constructor for intansiate in a room
    /// </summary>
    class Zombie : Enemy
    {
        public override int attackPower { get { return 20; } set {/*No need to set anything here*/} }
        public override string EnemyType {get { return "Zombie"; } set {/*No need to set anything here*/} } // Override the EnemyType so it's a Zombie
        public Zombie()
        {

        }
    }
}