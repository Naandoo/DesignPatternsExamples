using System;
using System.Collections.Generic;
using UnityEngine;

namespace Builder
{
    public class AirshipBuilder : IAirshipBuilder
    {
        [SerializeField] private GameObject _frontalWeapon;
        [SerializeField] private GameObject _leftWeapon;
        [SerializeField] private GameObject _rightWeapon;
        [SerializeField] private GameObject _leftWing;
        [SerializeField] private GameObject _rightWing;
        [SerializeField] private AirshipBuilderGUI _airshipBuilderGUI;
        public List<IAirshipModule> airshipModules { get; set; }
        [NonSerialized] public float totalSpeed;
        [NonSerialized] public float totalDamage;

        public Airship GetAirship()
        {
            throw new System.NotImplementedException();
        }

        public void SetFrontalWeapon(bool value)
        {
            ToggleAirshipModule(new AirshipWeapon(), value, _frontalWeapon);
            UpdateStatus(new AirshipWeapon(), value);
        }

        public void SetLeftWeapon(bool value)
        {
            ToggleAirshipModule(new AirshipWeapon(), value, _leftWeapon);
            UpdateStatus(new AirshipWeapon(), value);
        }

        public void SetRightWeapon(bool value)
        {
            ToggleAirshipModule(new AirshipWeapon(), value, _rightWeapon);
            UpdateStatus(new AirshipWeapon(), value);
        }

        public void SetLeftWing(bool value)
        {
            ToggleAirshipModule(new AirshipWing(), value, _leftWing);
            UpdateStatus(new AirshipWing(), value);
        }

        public void SetRightWing(bool value)
        {
            ToggleAirshipModule(new AirshipWing(), value, _rightWing);
            UpdateStatus(new AirshipWing(), value);
        }


        private void ToggleAirshipModule(IAirshipModule airshipModule, bool value, GameObject moduleGameObject)
        {
            if (value)
            {
                airshipModules.Add(airshipModule);
                moduleGameObject.SetActive(true);
            }
            else
            {
                airshipModules.Remove(airshipModule);
                moduleGameObject.SetActive(false);
            }
        }

        private void UpdateStatus(IAirshipModule airshipModule, bool value)
        {
            if (value)
            {
                totalSpeed += airshipModule.attributeBonus;
                totalDamage += airshipModule.attributeBonus;
            }
            else
            {
                totalSpeed -= airshipModule.attributeBonus;
                totalDamage -= airshipModule.attributeBonus;
            }

            _airshipBuilderGUI.UpdateUI();
        }
    }
}