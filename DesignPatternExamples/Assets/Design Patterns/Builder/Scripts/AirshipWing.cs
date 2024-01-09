namespace Builder
{
    public class AirshipWing : IAirshipModule
    {
        public AirshipModuleType airshipModule { get => AirshipModuleType.Wings; }
        public float attributeBonus { get => 20f; }
    }
}