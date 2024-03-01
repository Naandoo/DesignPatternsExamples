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
        [SerializeField] private Image _imageButton;
        [SerializeField] private Selectable _foodButton;
        public void UpdateGUI()
        {
            _foodIcon.sprite = _foodStore.Food.Icon;
            _foodPrice.text = _foodStore.Food.Cost.ToString();
        }

        public void ToggleObjectInteraction(bool value)
        {
            _imageButton.raycastTarget = value;
            _foodButton.interactable = value;
        }

        public void ClickedObjectAnimation()
        {
            float animationDuration = 0.1f;

            _imageButton.DOColor(Color.gray, animationDuration)
            .OnComplete(() => _imageButton.DOColor(Color.white, animationDuration));
        }

    }
}