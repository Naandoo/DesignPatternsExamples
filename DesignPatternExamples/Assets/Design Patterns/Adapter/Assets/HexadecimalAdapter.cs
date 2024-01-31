using UnityEngine;

namespace Adapter
{
    public class HexadecimalAdapter : IRGBColor
    {
        private Hexadecimal hexadecimal;

        public HexadecimalAdapter(Hexadecimal hexadecimal)
        {
            this.hexadecimal = hexadecimal;
        }

        public Color GetColorFromRGBWithAdapter(float r, float g, float b) => hexadecimal.ConvertRGBToHex(r, g, b);
    }
}