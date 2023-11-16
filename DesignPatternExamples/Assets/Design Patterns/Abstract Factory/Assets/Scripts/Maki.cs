using UnityEngine;

namespace AbstractFactory
{
    public class Maki : ISushi
    {
        [SerializeField] private float _satietyAmount;
        public void Eat()
        {

        }

        public float SatietyAmount => _satietyAmount;
    }
}