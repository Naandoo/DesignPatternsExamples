namespace Strategy
{
    public class ConcreteMummyStrategy : IStrategy
    {
        private CharacterStats _characterStats;
        public string Description { get; } = "A mummy who possesses the most infectious dance moves. However, it only unveils its legendary steps when it hears a party beat.";
        public int Health { get; } = 85;
        public int AttackDamage { get; } = 80;
        public int AttackSpeed { get; } = 25;
        public int Armor { get; } = 100;

        public ConcreteMummyStrategy()
        {
            _characterStats = new CharacterStats(Description, Health, AttackDamage, AttackSpeed, Armor);
        }
        public CharacterStats GetCharacterStats() => _characterStats;
    }
}