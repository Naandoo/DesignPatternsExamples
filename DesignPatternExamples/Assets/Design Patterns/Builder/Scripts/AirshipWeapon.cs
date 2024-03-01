namespace Builder
{
    public class AirshipWeapon : IAirshipModule
    {
        public AirshipModuleType airshipModule => AirshipModuleType.Weapon;
        public float attributeBonus => 30;
    }
}