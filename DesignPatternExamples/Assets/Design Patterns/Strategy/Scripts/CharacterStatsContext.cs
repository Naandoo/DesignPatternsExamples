public class CharacterStatsContext
{
    private IStrategy _strategy;
    public void SetStrategy(IStrategy strategy)
    {
        if (_strategy == null)
            throw new NullReferenceException("Strategy cannot be null!");
        _strategy = strategy;
    }
    public CharacterStats GetCharacterStats() => _strategy?.GetCharacterStats();
}