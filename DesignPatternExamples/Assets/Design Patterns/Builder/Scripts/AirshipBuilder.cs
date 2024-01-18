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
        private Airship _airship = new();

        public void GetAirship()
        {
            UpdateAirshipInfo();
            _airshipBuilderGUI.ShowCompletedAirshipMessage();
        }

        private void UpdateAirshipInfo()
        {
            _airship.hasLeftWing = hasLeftWing;
            _airship.hasRightWing = hasRightWing;
            _airship.hasLeftWeapon = hasLeftWing;
            _airship.hasRightWeapon = hasRightWing;
            _airship.hasFrontalWeapon = hasLeftWing;
            _airship.totalSpeed = totalSpeed;
            _airship.totalDamage = totalDamage;
        }

        public void SetFrontalWeapon(bool state) => ToggleAirshipModule(_airshipWeapon, state, _frontalWeapon);

        public void SetLeftWeapon(bool state) => ToggleAirshipModule(_airshipWeapon, state, _leftWeapon);

        public void SetRightWeapon(bool state) => ToggleAirshipModule(_airshipWeapon, state, _rightWeapon);

        public void SetLeftWing(bool state)
        {
            hasLeftWing = state;
            ToggleAirshipModule(_airshipWing, state, _leftWing);
            if (!hasLeftWing) DeactivateAirshipModule(_airshipWeapon, _leftWeapon);
        }

        public void SetRightWing(bool state)
        {
            hasRightWing = state;
            ToggleAirshipModule(_airshipWing, state, _rightWing);
            if (!hasRightWing) DeactivateAirshipModule(_airshipWeapon, _rightWeapon);
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
                    UpdateAttackDamage(airshipModule, value);
                    break;
                case AirshipModuleType.Wings:
                    UpdateSpeed(airshipModule, value);
                    break;
            }
        }

        private void UpdateAttackDamage(IAirshipModule airshipModule, bool value)
        {
            if (value) totalDamage += _airshipWeapon.attributeBonus;
            else totalDamage -= _airshipWeapon.attributeBonus;
            _airshipBuilderGUI.UpdateGUI(airshipModule);
        }

        private void UpdateSpeed(IAirshipModule airshipModule, bool value)
        {
            if (value) totalSpeed += _airshipWing.attributeBonus;
            else totalSpeed -= _airshipWing.attributeBonus;
            _airshipBuilderGUI.UpdateGUI(airshipModule);
        }
    }
}