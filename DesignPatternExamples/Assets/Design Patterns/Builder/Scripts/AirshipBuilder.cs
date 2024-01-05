using System.Collections.Generic;

public class AirshipBuilder : IAirshipBuilder
{
    public List<IAirshipModule> airshipModules { get; set; }
    private float _totalSpeed;
    private float _totalDamage;

    public Airship GetAirship()
    {
        throw new System.NotImplementedException();
    }

    public void SetWings()
    {
        airshipModules.Add(new AirshipModule(AirshipModuleType.Wings, _totalSpeed));
    }


    public void SetWeapons()
    {
    }
}