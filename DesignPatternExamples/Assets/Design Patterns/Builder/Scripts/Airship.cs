using System;
using UnityEngine;

namespace Builder
{
    public class Airship
    {
        [NonSerialized] public bool hasLeftWing;
        [NonSerialized] public bool hasRightWing;
        [NonSerialized] public bool hasLeftWeapon;
        [NonSerialized] public bool hasRightWeapon;
        [NonSerialized] public bool hasFrontalWeapon;
        [NonSerialized] public float totalSpeed;
        [NonSerialized] public float totalDamage;
    }
}