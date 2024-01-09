namespace Builder
{
    public interface IAirshipModule
    {
        AirshipModuleType airshipModule { get; }
        float attributeBonus { get; }
    }
}