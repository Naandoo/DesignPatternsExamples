using UnityEngine;

namespace AbstractFactory
{
    public class Hotroll : ISushi
    {
        [SerializeField] private float _satietyAmount;
        public void Eat()
        {

        }

        public float SatietyAmount => _satietyAmount;
    }
}