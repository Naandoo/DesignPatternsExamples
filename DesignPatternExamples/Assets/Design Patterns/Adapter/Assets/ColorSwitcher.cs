using TMPro;
using UnityEngine;

namespace Adapter
{
    public class ColorSwitcher : MonoBehaviour
    {
        [SerializeField] private Material _objectMaterial;
        private RGB _rgbConverter = new RGB();
        private Hexadecimal _hexConverter = new Hexadecimal();
        private HexadecimalAdapter _hexAdapter;

        public void UpdateColorOnRGBInput(TMP_Text r_text, TMP_Text g_text, TMP_Text b_text)
        {
            float r = float.Parse(r_text.text);
            float g = float.Parse(g_text.text);
            float b = float.Parse(b_text.text);

            _objectMaterial.color = _rgbConverter.GetColorFromRGBWithAdapter(r, g, b);
        }

        public void UpdateColorOnHexadecimalInput(TMP_Text hex_text) => _objectMaterial.color = _hexConverter.GetColorFromHex(hex_text.text);

        public void UpdateColorOnHexAdapterFromRGBInput(TMP_Text r_text, TMP_Text g_text, TMP_Text b_text)
        {
            float r = float.Parse(r_text.text);
            float g = float.Parse(g_text.text);
            float b = float.Parse(b_text.text);

            _hexAdapter = new HexadecimalAdapter(this._hexConverter);
            _objectMaterial.color = _hexAdapter.GetColorFromRGBWithAdapter(r, g, b);
        }
    }
}
