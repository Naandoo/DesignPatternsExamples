namespace Strategy
{
    public class ConcreteWarriorStrategy : IStrategy
    {
        private CharacterStats _characterStats;
        public string Description { get; } = "A brave warrior who fights for honor and glory, but have existential crisis about the defeated enemies";
        public int Health { get; } = 85;
        public int AttackDamage { get; } = 80;
        public int AttackSpeed { get; } = 25;
        public int Armor { get; } = 100;

        public ConcreteWarriorStrategy()
        {
            _characterStats = new CharacterStats(Description, Health, AttackDamage, AttackSpeed, Armor);
        }

        public CharacterStats GetCharacterStats() => _characterStats;
    }
}