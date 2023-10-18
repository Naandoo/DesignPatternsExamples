public class ConcreteNinjaStrategy : IStrategy
{
    public string _description => "A ninja who is a master of stealth and martial arts, but have a fear of heights";

    public int _health => 55;

    public int _attackDamage => 60;

    public int _attackSpeed => 60;

    public int _armor => 60;

    public CharacterStats GetCharacterStats() => new(_description, _health, _attackDamage, _attackSpeed, _armor);
}