namespace Strategy
{
    public class ConcreteWarriorStrategy : IStrategy
    {
        private string _description = "A brave warrior who fights for honor and glory, but have existential crisis about the defeated enemies";
        private int _health = 85;
        private int _attackDamage = 80;
        private int _attackSpeed = 25;
        private int _armor = 100;
        private CharacterStats _characterStats;

        public ConcreteWarriorStrategy()
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
