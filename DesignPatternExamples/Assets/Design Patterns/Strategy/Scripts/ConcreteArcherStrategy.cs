namespace Strategy
{
    public class ConcreteArcherStrategy : IStrategy
    {
        private string _description = "An archer with the most deadly aim in the world, but only when he is drunk";
        private int _health = 45;
        private int _attackDamage = 50;
        private int _attackSpeed = 85;
        private int _armor = 40;
        private CharacterStats _characterStats;

        public ConcreteArcherStrategy()
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