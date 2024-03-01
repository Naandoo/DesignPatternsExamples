using UnityEngine;

namespace Adapter
{
    public class Hexadecimal : IHexadecimalColor
    {
        public Color GetColorFromHex(string hexCode)
        {
            Color color = new();
            string hexCodeWithHash = '#' + hexCode;
            ColorUtility.TryParseHtmlString(hexCodeWithHash, out color);
            return color;
        }

        public Color ConvertRGBToHex(float r, float g, float b)
        {
            byte rByte = (byte)r;
            byte gByte = (byte)g;
            byte bByte = (byte)b;

            string hexCode = ColorUtility.ToHtmlStringRGB(new Color32(rByte, gByte, bByte, 255));
            return GetColorFromHex(hexCode);
        }
    }
}