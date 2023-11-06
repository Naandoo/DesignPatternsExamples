namespace Strategy
{
    public class CharacterStats
    {
        public string _description;
        public int _health;
        public int _attackDamage;
        public int _attackSpeed;
        public int _armor;

        public CharacterStats(string description, int health, int attackDamage, int attackSpeed, int armor)
        {
            _description = description;
            _health = health;
            _attackDamage = attackDamage;
            _attackSpeed = attackSpeed;
            _armor = armor;
        }
    }
}