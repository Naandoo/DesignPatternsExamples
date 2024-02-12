using UnityEngine;

namespace ScriptableVariable
{
    [CreateAssetMenu(fileName = "FloatVariable", menuName = "ScriptableObjects/FloatVariable")]
    public class FloatVariable : ScriptableVariable<float>
    {
        private float minValue = float.MinValue;
        private float maxValue = float.MaxValue;

        public void Add(float value)
        {
            Value += value;
        }

        public override float Value
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