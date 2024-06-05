using TMPro;
using UnityEngine;

namespace Adapter
{
    public class ColorSwitcher : MonoBehaviour
    {
        [SerializeField] private Material _objectMaterial;
        [SerializeField] private TMP_InputField _r_text_onRGBInput;
        [SerializeField] private TMP_InputField _g_text_onRGBInput;
        [SerializeField] private TMP_InputField _b_text_onRGBInput;
        [SerializeField] private TMP_InputField _hex_text_onHexadecimalInput;
        [SerializeField] private TMP_InputField _r_text_onHexAdapterFromRGBInput;
        [SerializeField] private TMP_InputField _g_text_onHexAdapterFromRGBInput;
        [SerializeField] private TMP_InputField _b_text_onHexAdapterFromRGBInput;
        private RGB _rgbConverter = new RGB();
        private Hexadecimal _hexConverter = new Hexadecimal();
        private HexadecimalAdapter _hexAdapter;


        public void UpdateColorOnRGBInput() => UpdateColorWithRGB(_r_text_onRGBInput, _g_text_onRGBInput, _b_text_onRGBInput);
        public void UpdateColorOnHexadecimalInput() => UpdateColorWithHexadecimal(_hex_text_onHexadecimalInput);
        public void UpdateColorOnHexAdapterFromRGBInput() => UpdateColorWithHexAdapter(_r_text_onHexAdapterFromRGBInput, _g_text_onHexAdapterFromRGBInput, _b_text_onHexAdapterFromRGBInput);

        private void UpdateColorWithRGB(TMP_InputField r_text, TMP_InputField g_text, TMP_InputField b_text)
        {
            int r = int.Parse(r_text.text);
            int g = int.Parse(g_text.text);
            int b = int.Parse(b_text.text);

            _objectMaterial.color = _rgbConverter.GetColorFromRGBWithAdapter(r, g, b);
        }

        private void UpdateColorWithHexadecimal(TMP_InputField hex_text) => _objectMaterial.color = _hexConverter.GetColorFromHex(hex_text.text);

        private void UpdateColorWithHexAdapter(TMP_InputField r_text, TMP_InputField g_text, TMP_InputField b_text)
        {
            int r = int.Parse(r_text.text);
            int g = int.Parse(g_text.text);
            int b = int.Parse(b_text.text);

            _hexAdapter = new HexadecimalAdapter(this._hexConverter);
            _objectMaterial.color = _hexAdapter.GetColorFromRGBWithAdapter(r, g, b);
        }
    }
}
