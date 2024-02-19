using UnityEngine;
using UnityEngine.UI;
using TMPro;
namespace Decorator
{
    public class InventoryObject : MonoBehaviour
    {
        [SerializeField] private Image _icon;
        [SerializeField] private TMP_Text _cost;
        [SerializeField] private Button _button;
        private Food _food;
        public Food Food { get => _food; }

        public void SetObject(Food food)
        {
            _food = food;
            _icon.sprite = food.Icon;
            _cost.text = food.Cost.ToString();
        }
    }
}