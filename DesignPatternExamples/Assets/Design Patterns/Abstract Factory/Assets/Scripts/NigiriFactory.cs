using UnityEngine;

namespace AbstractFactory
{
    public class NigiriFactory : IAbstractFactory
    {
        [SerializeField] private Nigiri _nigiriPrefab;

        public ISushi CreateSushi()
        {
            throw new System.NotImplementedException();
        }
    }
}