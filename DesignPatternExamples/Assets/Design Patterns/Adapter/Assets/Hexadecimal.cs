using UnityEngine;

namespace Adapter
{
    public class Hexadecimal : IHexadecimalColor
    {
        public Color GetColorFromHex(string hexCode)
        {
            Color color = new Color();
            ColorUtility.TryParseHtmlString(hexCode, out color);
            return color;
        }

        public Color ConvertRGBToHex(float r, float g, float b)
        {
            string hexCode = ColorUtility.ToHtmlStringRGB(new Color(r, g, b));
            return GetColorFromHex(hexCode);
        }
    }
}