using System.Collections.Generic;

namespace Builder
{
    public interface IAirshipBuilder
    {
        IList<IAirshipModule> airshipModules { get; }
        void SetLeftWingActive(bool value);
        void SetRightWingActive(bool value);
        void SetLeftWeaponActive(bool value);
        void SetRightWeaponActive(bool value);
        void SetFrontalWeaponActive(bool value);
        void OnAirshipCompleted();
    }
}