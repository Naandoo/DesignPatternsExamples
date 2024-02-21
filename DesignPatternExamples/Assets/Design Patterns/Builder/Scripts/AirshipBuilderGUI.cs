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
        [SerializeField] private GameObject _completedAirshipMessage;
        private Vector3 _completedAirshipMessageInitialPosition;

        private void Start()
        {
            UpdateAttackDamageGUI();
            UpdateSpeedGUI();

            _completedAirshipMessageInitialPosition = _completedAirshipMessage.transform.position;
        }

        public void UpdateAttackDamageGUI()
        {
            float duration = 0.5f;
            _attackFillBar.DOFillAmount(_airshipBuilder.TotalDamage / 100f, duration);
            CheckSideWeaponsAvailability();
        }

        public void UpdateSpeedGUI()
        {
            float duration = 0.5f;
            _speedFillBar.DOFillAmount(_airshipBuilder.TotalSpeed / 100f, duration);
            CheckSideWeaponsAvailability();
        }

        public void ShowCompletedAirshipMessage()
        {
            if (_completedAirshipMessage.transform.position != _completedAirshipMessageInitialPosition)
                return;

            float movementAmount = 275;
            float duration = 1f;

            _completedAirshipMessage.transform
            .DOMoveY(_completedAirshipMessageInitialPosition.y + movementAmount, duration)
            .SetEase(Ease.OutBack)
            .OnComplete(() =>
            {
                _completedAirshipMessage.transform
                .DOMoveY(_completedAirshipMessage.transform.position.y - movementAmount, duration)
                .SetEase(Ease.InBack);
            });
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