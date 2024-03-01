using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Prototype
{
    public class Base : MonoBehaviour
    {
        [SerializeField] private Image _healthBar;
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
            _healthBar.fillAmount = currentHealth / maxHealth;

        }
    }
}