namespace Builder
{
    public class AirshipWeapon : IAirshipModule
    {
        public AirshipModuleType airshipModule { get => AirshipModuleType.Weapon; }
        public float attributeBonus { get => 15f; }
    }
}