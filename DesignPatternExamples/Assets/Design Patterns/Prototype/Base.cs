using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Prototype
{
    public class Base : MonoBehaviour
    {
        [SerializeField] private Image _healthBar;
        [SerializeField] private TMP_Text _healthText;
        private float currentHealth;
        private float maxHealth = 100f;

        private void Start()
        {
            currentHealth = maxHealth;
        }

        public void ReceiveDamage(int amount)
        {
            currentHealth -= amount;
            if (currentHealth <= 0) currentHealth = maxHealth;
            // _healthBar.fillAmount = currentHealth / maxHealth;
            // _healthText.text = $"{currentHealth} / {maxHealth}";

            Debug.Log($"Base received {amount} damage");
            Debug.Log($"Base current health: {currentHealth}");
        }
    }
}