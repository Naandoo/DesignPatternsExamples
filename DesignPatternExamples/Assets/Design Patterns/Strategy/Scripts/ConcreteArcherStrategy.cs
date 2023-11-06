public class ConcreteArcherStrategy : IStrategy
{
    public string _description => "An archer with the most deadly aim in the world, but only when he is drunk";

    public int _health = 45;

    public int _attackDamage = 50;

    public int _attackSpeed = 85;

    public int _armor = 40;

    public CharacterStats GetCharacterStats() => new(_description, _health, _attackDamage, _attackSpeed, _armor);
}