using UnityEngine;
using UnityEngine.UI;
namespace Builder
{
    public class AirshipBuilderGUI : MonoBehaviour
    {
        [SerializeField] private Image _attackFillBar;
        [SerializeField] private Image _speedFillBar;
        [SerializeField] private AirshipBuilder _airshipBuilder;

        public void UpdateUI()
        {
            _attackFillBar.fillAmount = _airshipBuilder.totalDamage / 100f;
            _speedFillBar.fillAmount = _airshipBuilder.totalSpeed / 100f;
        }

        public void ShowCompletedAirshipMessage()
        {

        }
    }
}