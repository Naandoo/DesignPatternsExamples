using UnityEngine;

namespace AbstractFactory
{
    public class MakiFactory : IAbstractFactory
    {
        [SerializeField] private Maki _makiPrefab;

        public ISushi CreateSushi()
        {
            throw new System.NotImplementedException();
        }
    }
}