public interface IStrategy
{
    string Description { get; }
    int Health { get; }
    int AttackDamage { get; }
    int AttackSpeed { get; }
    int Armor { get; }
    CharacterStats GetCharacterStats();
}
