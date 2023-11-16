using UnityEngine;

namespace AbstractFactory
{
    public class ClientOrderButton : MonoBehaviour
    {
        [SerializeField] private IAbstractFactory _factory;
        [SerializeField] private float _satietyAmount;

        public void OnClick() => _factory.CreateSushi();
    }
}