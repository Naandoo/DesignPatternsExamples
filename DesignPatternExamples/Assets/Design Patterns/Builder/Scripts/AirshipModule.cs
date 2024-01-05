public class AirshipModule : IAirshipModule
{
    public AirshipModuleType airshipModule { get; set; }
    public float attributeBonus { get; set; }

    public AirshipModule(AirshipModuleType airshipModule, float attributeBonus)
    {
        this.airshipModule = airshipModule;
        this.attributeBonus = attributeBonus;
    }
}

public enum AirshipModuleType
{
    Wings,
    Weapon,
}