using System.Collections.Generic;

public interface IAirshipBuilder
{
    List<IAirshipModule> airshipModules { get; set; }
    void SetWings();
    void SetWeapons();
    Airship GetAirship();
}