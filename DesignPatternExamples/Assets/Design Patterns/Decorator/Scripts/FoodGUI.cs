using UnityEngine;
using UnityEngine.UI;
using ScriptableVariable;
using TMPro;
using DG.Tweening;
namespace Decorator
{
    public class FoodGUI : MonoBehaviour
    {
        [SerializeField] private FoodStore _foodStore;
        [SerializeField] private Image _foodIcon;
        [SerializeField] private TMP_Text _foodPrice;
        [SerializeField] private Selectable _foodButton;
        [SerializeField] private IntVariable _moneyAmount;
        [SerializeField] private Inventory _inventory;

        public void UpdateGUI()
        {
            _foodIcon.sprite = _foodStore.Food.Icon;
            _foodPrice.text = _foodStore.Food.Cost.ToString();
        }

        public void ToggleObjectInteraction(bool value) => _foodButton.interactable = value;

        public void ClickedObjectAnimation()
        {
            float animationDuration = 0.1f;

            _foodButton.image.DOColor(Color.gray, animationDuration)
            .OnComplete(() => _foodButton.image.DOColor(Color.white, animationDuration));
        }
    }
}