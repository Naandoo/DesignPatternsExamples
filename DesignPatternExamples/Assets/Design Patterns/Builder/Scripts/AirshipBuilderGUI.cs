using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

namespace Builder
{
    public class AirshipBuilderGUI : MonoBehaviour
    {
        [SerializeField] private Image _attackFillBar;
        [SerializeField] private Image _speedFillBar;
        [SerializeField] private AirshipBuilder _airshipBuilder;
        [SerializeField] Toggle _ToggleLeftWeapon;
        [SerializeField] private Image _leftWeaponToggleCheck;
        [SerializeField] Toggle _ToggleRightWeapon;
        [SerializeField] private Image _rightWeaponToggleCheck;

        private void Start()
        {
            UpdateAttackDamageGUI();
            UpdateSpeedGUI();
        }

        public void UpdateGUI(IAirshipModule airshipModule)
        {
            switch (airshipModule.airshipModule)
            {
                case AirshipModuleType.Weapon:
                    UpdateAttackDamageGUI();
                    break;
                case AirshipModuleType.Wings:
                    UpdateSpeedGUI();
                    break;
            }

            CheckSideWeaponsAvailability();
        }

        private void UpdateAttackDamageGUI() => _attackFillBar.DOFillAmount(_airshipBuilder.totalDamage / 100f, 0.5f);

        private void UpdateSpeedGUI() => _speedFillBar.DOFillAmount(_airshipBuilder.totalSpeed / 100f, 0.5f);

        public void ShowCompletedAirshipMessage()
        {

        }

        private void CheckSideWeaponsAvailability()
        {
            CheckLeftWeapon();
            CheckRightWeapon();
        }

        private void CheckLeftWeapon()
        {
            _ToggleLeftWeapon.interactable = _airshipBuilder.hasLeftWing;
            FixToggleOnWeaponAvailability(_leftWeaponToggleCheck, _airshipBuilder.hasLeftWing, _ToggleLeftWeapon);
        }

        private void CheckRightWeapon()
        {
            _ToggleRightWeapon.interactable = _airshipBuilder.hasRightWing;
            FixToggleOnWeaponAvailability(_rightWeaponToggleCheck, _airshipBuilder.hasRightWing, _ToggleRightWeapon);
        }

        private void FixToggleOnWeaponAvailability(Image toggleCheck, bool state, Toggle toggle)
        {
            if (toggleCheck.enabled && !state)
            {
                toggle.isOn = false;
                toggleCheck.enabled = false;
            }
        }

    }
}