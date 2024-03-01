using UnityEngine;
using TMPro;

namespace ScriptableVariable
{
    public class IntVariableText : MonoBehaviour
    {
        [SerializeField] private TMP_Text _text;
        [SerializeField] private IntVariable _variable;

        public void OnEnable()
        {
            _variable.OnValueChanged += UpdateText;
            UpdateText(_variable.Value);
        }

        public void OnDisable() => _variable.OnValueChanged -= UpdateText;

        public void UpdateText(int value) => _text.text = value.ToString();
    }
}