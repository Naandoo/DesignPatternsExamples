using System;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

namespace Builder
{
    public class AirshipBuilder : MonoBehaviour, IAirshipBuilder
    {
        [SerializeField] private GameObject _frontalWeapon;
        [SerializeField] private GameObject _leftWeapon;
        [SerializeField] private GameObject _rightWeapon;
        [SerializeField] private GameObject _leftWing;
        [SerializeField] private GameObject _rightWing;
        [SerializeField] private AirshipBuilderGUI _airshipBuilderGUI;
        public List<IAirshipModule> airshipModules { get; set; } = new List<IAirshipModule>();
        [NonSerialized] public float totalSpeed = 10f;
        [NonSerialized] public float totalDamage = 10f;
        [NonSerialized] public bool hasLeftWing;
        [NonSerialized] public bool hasRightWing;
        private AirshipWeapon _airshipWeapon = new();
        private AirshipWing _airshipWing = new();
        public Airship GetAirship()
        {
            throw new System.NotImplementedException();
        }

        public void SetFrontalWeapon(bool state) => ToggleAirshipModule(_airshipWeapon, state, _frontalWeapon);

        public void SetLeftWeapon(bool state) => ToggleAirshipModule(_airshipWeapon, state, _leftWeapon);

        public void SetRightWeapon(bool state) => ToggleAirshipModule(_airshipWeapon, state, _rightWeapon);

        public void SetLeftWing(bool state)
        {
            hasLeftWing = state;
            ToggleAirshipModule(_airshipWing, state, _leftWing);
            if (!hasLeftWing) SetLeftWeapon(false);
        }

        public void SetRightWing(bool state)
        {
            hasRightWing = state;
            ToggleAirshipModule(_airshipWing, state, _rightWing);
            if (!hasRightWing) SetRightWeapon(false);
        }

        private void ToggleAirshipModule(IAirshipModule airshipModule, bool value, GameObject moduleGameObject)
        {
            if (value) ActivateAirshipModule(airshipModule, moduleGameObject);
            else DeactivateAirshipModule(airshipModule, moduleGameObject);

            UpdateStatus(airshipModule, value);
        }

        private void ActivateAirshipModule(IAirshipModule airshipModule, GameObject moduleGameObject)
        {
            airshipModules.Add(airshipModule);
            moduleGameObject.SetActive(true);
        }

        private void DeactivateAirshipModule(IAirshipModule airshipModule, GameObject moduleGameObject)
        {
            if (airshipModules.Contains(airshipModule))
            {
                airshipModules.Remove(airshipModule);
                moduleGameObject.SetActive(false);
            }
        }

        private void UpdateStatus(IAirshipModule airshipModule, bool value)
        {
            switch (airshipModule.airshipModule)
            {
                case AirshipModuleType.Weapon:
                    UpdateAttackDamage(value);
                    break;
                case AirshipModuleType.Wings:
                    UpdateSpeed(value);
                    break;
            }
        }

        private void UpdateAttackDamage(bool value)
        {
            if (value) totalDamage += _airshipWeapon.attributeBonus;
            else totalDamage -= _airshipWeapon.attributeBonus;
            _airshipBuilderGUI.UpdateGUI(_airshipWeapon);
        }

        private void UpdateSpeed(bool value)
        {
            if (value) totalSpeed += _airshipWing.attributeBonus;
            else totalSpeed -= _airshipWing.attributeBonus;
            _airshipBuilderGUI.UpdateGUI(_airshipWing);
        }
    }
}