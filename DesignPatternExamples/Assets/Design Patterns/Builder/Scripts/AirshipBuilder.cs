using System;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.Events;

namespace Builder
{
    public class AirshipBuilder : MonoBehaviour, IAirshipBuilder
    {
        [SerializeField] private GameObject _frontalWeapon;
        [SerializeField] private GameObject _leftWeapon;
        [SerializeField] private GameObject _rightWeapon;
        [SerializeField] private GameObject _leftWing;
        [SerializeField] private GameObject _rightWing;
        [SerializeField] private UnityEvent _OnAirshipDamageChanged;
        [SerializeField] private UnityEvent _OnAirshipSpeedChanged;
        [SerializeField] private UnityEvent _onAirshipCompleted;
        [NonSerialized] public bool hasLeftWing;
        [NonSerialized] public bool hasRightWing;

        private AirshipWeapon _airshipWeapon = new();
        private AirshipWing _airshipWing = new();
        public float TotalSpeed => CalculateSpeed();
        public float TotalDamage => CalculateDamage();
        private List<IAirshipModule> _airshipModules = new();
        public IList<IAirshipModule> airshipModules => _airshipModules.AsReadOnly();


        public void OnAirshipCompleted() => _onAirshipCompleted.Invoke();

        public void SetFrontalWeaponActive(bool state) => ToggleAirshipModule(_airshipWeapon, state, _frontalWeapon);

        public void SetLeftWeaponActive(bool state) => ToggleAirshipModule(_airshipWeapon, state, _leftWeapon);

        public void SetRightWeaponActive(bool state) => ToggleAirshipModule(_airshipWeapon, state, _rightWeapon);

        public void SetLeftWingActive(bool state)
        {
            hasLeftWing = state;
            ToggleAirshipModule(_airshipWing, state, _leftWing);
            if (!hasLeftWing) DeactivateAirshipModule(_airshipWeapon, _leftWeapon);
        }

        public void SetRightWingActive(bool state)
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
            _airshipModules.Add(airshipModule);
            moduleGameObject.SetActive(true);
        }

        private void DeactivateAirshipModule(IAirshipModule airshipModule, GameObject moduleGameObject)
        {
            if (airshipModules.Contains(airshipModule))
            {
                _airshipModules.Remove(airshipModule);
                moduleGameObject.SetActive(false);
            }
        }

        private void UpdateStatus(IAirshipModule airshipModule, bool value)
        {
            switch (airshipModule.airshipModule)
            {
                case AirshipModuleType.Weapon:
                    UpdateAttackDamage();
                    break;
                case AirshipModuleType.Wings:
                    UpdateSpeed();
                    break;
            }
        }

        private void UpdateAttackDamage()
        {
            CalculateDamage();
            _OnAirshipDamageChanged.Invoke();
        }

        private void UpdateSpeed()
        {
            CalculateSpeed();
            _OnAirshipSpeedChanged.Invoke();
        }

        private float CalculateSpeed()
        {
            float initialSpeed = 10;
            float currentSpeed = initialSpeed;

            foreach (IAirshipModule module in airshipModules)
            {
                if (module.airshipModule == AirshipModuleType.Wings) currentSpeed += module.attributeBonus;
            }

            return currentSpeed;
        }

        private float CalculateDamage()
        {
            float initialDamage = 10;
            float currentDamage = initialDamage;

            foreach (IAirshipModule module in airshipModules)
            {
                if (module.airshipModule == AirshipModuleType.Weapon) currentDamage += module.attributeBonus;
            }


            return currentDamage;
        }
    }
}