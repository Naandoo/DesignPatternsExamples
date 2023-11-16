using UnityEngine;

namespace AbstractFactory
{
    public class SashimiFactory : IAbstractFactory
    {
        [SerializeField] private Sashimi _sashimiPrefab;

        public ISushi CreateSushi()
        {
            throw new System.NotImplementedException();
        }
    }
}