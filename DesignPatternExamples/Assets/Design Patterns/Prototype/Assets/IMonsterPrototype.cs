namespace Prototype
{
    public interface IMonsterPrototype
    {
        int AttackDamage { get; set; }
        IMonsterPrototype Clone();
    }
}