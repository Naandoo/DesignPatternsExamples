using System.Collections.Generic;

namespace Builder
{
    public interface IAirshipBuilder
    {
        List<IAirshipModule> airshipModules { get; set; }
        void SetLeftWing(bool value);
        void SetRightWing(bool value);
        void SetLeftWeapon(bool value);
        void SetRightWeapon(bool value);
        void SetFrontalWeapon(bool value);
        void GetAirship();
    }
}