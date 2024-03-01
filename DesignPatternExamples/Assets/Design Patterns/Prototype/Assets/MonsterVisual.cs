using System.Collections.Generic;
using UnityEngine;

namespace Prototype
{
    public class MonsterVisual : MonoBehaviour
    {
        public List<GameObject> _availableSkins;

        private void OnEnable()
        {
            RandomizeSkin();
        }

        private void RandomizeSkin()
        {
            int randomIndex = Random.Range(0, _availableSkins.Count);
            ToggleSelectedSkin(_availableSkins[randomIndex]);
        }

        private void ToggleSelectedSkin(GameObject skin)
        {
            foreach (GameObject availableSkin in _availableSkins)
            {
                availableSkin.SetActive(skin == availableSkin);
            }
        }
    }
}
