using UnityEngine;

namespace AbstractFactory
{
    public class Nigiri : ISushi
    {
        [SerializeField] private float _satietyAmount;
        public void Eat()
        {

        }

        public float SatietyAmount => _satietyAmount;
    }
}