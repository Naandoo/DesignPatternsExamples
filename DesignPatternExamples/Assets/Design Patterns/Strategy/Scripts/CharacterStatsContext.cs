using System;

namespace Strategy
{
    public class CharacterStatsContext
    {
        private IStrategy _strategy;
        public void SetStrategy(IStrategy strategy) => _strategy = strategy ?? throw new NullReferenceException("Strategy cannot be null!");
        public CharacterStats GetCharacterStats() => _strategy?.GetCharacterStats();
    }
}