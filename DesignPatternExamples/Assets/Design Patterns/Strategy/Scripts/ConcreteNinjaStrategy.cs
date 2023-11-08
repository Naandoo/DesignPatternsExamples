namespace Strategy
{
    public class ConcreteNinjaStrategy : IStrategy
    {
        private CharacterStats _characterStats;
        public string Description { get; } = "A ninja who is a master of stealth and martial arts, but have a fear of heights";
        public int Health { get; } = 85;
        public int AttackDamage { get; } = 80;
        public int AttackSpeed { get; } = 25;
        public int Armor { get; } = 100;

        public ConcreteNinjaStrategy()
        {
            _characterStats = new CharacterStats(Description, Health, AttackDamage, AttackSpeed, Armor);
        }
        public CharacterStats GetCharacterStats() => _characterStats;
    }
}