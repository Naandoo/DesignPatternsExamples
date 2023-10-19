public class ConcreteWarriorStrategy : IStrategy
{
    public string _description => "A brave warrior who fights for honor and glory, but have existential crisis about the defeated enemies";

    public int _health => 85;

    public int _attackDamage => 80;

    public int _attackSpeed => 25;

    public int _armor => 100;

    public CharacterStats GetCharacterStats() => new(_description, _health, _attackDamage, _attackSpeed, _armor);
}