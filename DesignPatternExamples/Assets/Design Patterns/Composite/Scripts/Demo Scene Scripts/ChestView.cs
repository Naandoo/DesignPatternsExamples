using UnityEngine;
using ScriptableVariable;
using UnityEngine.UI;

namespace Composite
{
    public class ChestView : MonoBehaviour
    {
        [SerializeField] private GameObject _chest;
        [SerializeField] private Animator _chestAnimator;
        [SerializeField] private IntVariable _chestCount;
        [SerializeField] private Button _chestButton;
        private const string _chestAppearing = "ChestAppearing";

        private void Start() => CheckChestsRemaining();

        public void CheckChestsRemaining()
        {
            if (_chestCount.Value > 0)
            {
                _chest.SetActive(true);
                _chestAnimator.Play(_chestAppearing);
                ToggleChestButton(true);
            }
        }

        public void ToggleChestButton(bool state) => _chestButton.interactable = state;
        public void DisableCurrentChest() => _chest.SetActive(false);
    }
}