using UnityEngine;

namespace ScriptableVariable
{
    [CreateAssetMenu(fileName = "IntVariable", menuName = "ScriptableObjects/IntVariable")]
    public class IntVariable : ScriptableVariable<int>
    {
        private int minValue = int.MinValue;
        private int maxValue = int.MaxValue;

        public void Add(int value)
        {
            Value += value;
        }

        public override int Value
        {
            get => base.Value;
            set
            {
                if (value < minValue)
                {
                    base.Value = minValue;
                }
                else if (value > maxValue)
                {
                    base.Value = maxValue;
                }
                else
                {
                    base.Value = value;
                }
            }
        }

#if UNITY_EDITOR
        protected override void OnValidate()
        {
            base.OnValidate();
        }
#endif
    }
}