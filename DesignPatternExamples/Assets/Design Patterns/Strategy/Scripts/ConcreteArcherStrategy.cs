namespace Strategy
{
    public class ConcreteArcherStrategy : IStrategy
    {
        private CharacterStats _characterStats;

        public string Description { get; } = "An archer with the most deadly aim in the world, but only when he is drunk";
        public int Health { get; } = 45;
        public int AttackDamage { get; } = 50;
        public int AttackSpeed { get; } = 85;
        public int Armor { get; } = 40;

        public ConcreteArcherStrategy()
        {
            _characterStats = new CharacterStats(Description, Health, AttackDamage, AttackSpeed, Armor);
        }

        public CharacterStats GetCharacterStats() => _characterStats;
    }
}