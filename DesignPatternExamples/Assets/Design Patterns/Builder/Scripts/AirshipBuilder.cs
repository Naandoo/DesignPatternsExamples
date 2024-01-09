using System;
using System.Collections.Generic;

namespace Builder
{
    public class AirshipBuilder : IAirshipBuilder
    {
        public List<IAirshipModule> airshipModules { get; set; }
        [NonSerialized] public float _totalSpeed;
        [NonSerialized] public float _totalDamage;

        public Airship GetAirship()
        {
            throw new System.NotImplementedException();
        }

        public void AddWing() => airshipModules.Add(new AirshipWing());
        public void AddWeapon() => airshipModules.Add(new AirshipWeapon());
        public void Undo() => airshipModules.RemoveAt(airshipModules.Count - 1);
    }
}