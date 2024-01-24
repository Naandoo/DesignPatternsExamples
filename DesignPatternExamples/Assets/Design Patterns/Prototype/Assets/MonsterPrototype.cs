namespace Prototype
{
    public class MonsterPrototype : IMonsterPrototype
    {
        public int AttackDamage { get; set; }

        public IMonsterPrototype Clone()
        {
            return new MonsterPrototype
            {
                AttackDamage = this.AttackDamage
            };
        }
    }
}