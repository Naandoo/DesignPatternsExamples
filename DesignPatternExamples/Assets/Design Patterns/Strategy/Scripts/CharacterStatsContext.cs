public class CharacterStatsContext
{
    private IStrategy _strategy;
    public void SetStrategy(IStrategy strategy) => _strategy = strategy;
    public CharacterStats GetCharacterStats() => _strategy.GetCharacterStats();
}