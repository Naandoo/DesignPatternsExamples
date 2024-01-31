using UnityEngine;

namespace Adapter
{
    public class RGB : IRGBColor
    {
        public Color GetColorFromRGBWithAdapter(int r, int g, int b)
        {
            r = GetValueInRange(r);
            g = GetValueInRange(g);
            b = GetValueInRange(b);

            byte rByte = (byte)r;
            byte gByte = (byte)g;
            byte bByte = (byte)b;

            return new Color32(rByte, gByte, bByte, 255);
        }

        private int GetValueInRange(int value) => value > 255 ? 255 : value < 0 ? 0 : value;
    }
}