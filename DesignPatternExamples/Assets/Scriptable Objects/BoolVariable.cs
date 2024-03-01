using UnityEngine;

namespace ScriptableVariable
{
    [CreateAssetMenu(fileName = "BoolVariable", menuName = "ScriptableObjects/BoolVariable")]
    public class BoolVariable : ScriptableVariable<bool>
    {
        public void Toggle()
        {
            Value = !Value;
        }
    }
}