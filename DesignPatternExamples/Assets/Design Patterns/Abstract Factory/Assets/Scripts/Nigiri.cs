using UnityEngine;

namespace AbstractFactory
{
    public class Nigiri : MonoBehaviour, ISushi
    {
        [SerializeField] private float _satietyAmount;
        private Feedback _feedback = new();
        public AbstractFactory Factory { get; set; }

        public void Eat()
        {
            _feedback.onEatAnimation(transform, () =>
            {
                Factory.PoolSystem.Return(this.gameObject);
            });
        }

        public float SatietyAmount => _satietyAmount;

    }
}