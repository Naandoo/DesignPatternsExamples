namespace Strategy
{
    public class ConcreteNinjaStrategy : IStrategy
    {
        private string _description = "A ninja who is a master of stealth and martial arts, but have a fear of heights";
        private int _health = 55;
        private int _attackDamage = 60;
        private int _attackSpeed = 60;
        private int _armor = 60;
        private CharacterStats _characterStats;

        public ConcreteNinjaStrategy()
        {
            _characterStats = new CharacterStats(_description, _health, _attackDamage, _attackSpeed, _armor);
        }

        public string Description { get => _description; set => _description = value; }
        public int Health { get => _health; set => _health = value; }
        public int AttackDamage { get => _attackDamage; set => _attackDamage = value; }
        public int AttackSpeed { get => _attackSpeed; set => _attackSpeed = value; }
        public int Armor { get => _armor; set => _armor = value; }

        public CharacterStats GetCharacterStats() => _characterStats;
    }
}