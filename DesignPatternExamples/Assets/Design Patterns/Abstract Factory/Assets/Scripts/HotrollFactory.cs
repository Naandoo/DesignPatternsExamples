using UnityEngine;

namespace AbstractFactory
{
    public class HotrollFactory : IAbstractFactory
    {
        [SerializeField] private Hotroll _hotrollPrefab;

        public ISushi CreateSushi()
        {
            throw new System.NotImplementedException();
        }
    }
}