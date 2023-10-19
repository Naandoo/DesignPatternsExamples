public interface IStrategy
{
    string _description { get; }
    int _health { get; }
    int _attackDamage { get; }
    int _attackSpeed { get; }
    int _armor { get; }
    CharacterStats GetCharacterStats();
}
