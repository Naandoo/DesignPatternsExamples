using System.Collections.Generic;

namespace Builder
{
    public interface IAirshipBuilder
    {
        List<IAirshipModule> airshipModules { get; set; }
        void AddWing();
        void AddWeapon();
        Airship GetAirship();
        void Undo();
    }
}