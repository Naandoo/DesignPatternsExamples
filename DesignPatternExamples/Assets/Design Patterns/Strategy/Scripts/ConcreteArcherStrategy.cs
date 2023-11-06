public class ConcreteArcherStrategy : IStrategy
{
<<<<<<< HEAD
    public string _description => "An archer with the most deadly aim in the world, but only when he is drunk";
=======
    public string _description = "A archer with the most deadly aim in the world, but only if he is drunk";
>>>>>>> Strategy

    public int _health = 45;

    public int _attackDamage = 50;

    public int _attackSpeed = 85;

    public int _armor = 40;

    public CharacterStats GetCharacterStats() => new(_description, _health, _attackDamage, _attackSpeed, _armor);
}