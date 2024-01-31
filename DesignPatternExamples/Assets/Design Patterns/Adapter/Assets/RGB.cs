using UnityEngine;

namespace Adapter
{
    public class RGB : IRGBColor
    {
        public Color GetColorFromRGBWithAdapter(float r, float g, float b)
        {
            return new Color(r, g, b);
        }
    }
}