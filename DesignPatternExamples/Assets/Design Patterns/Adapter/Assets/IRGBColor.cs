using UnityEngine;

namespace Adapter
{
    public interface IRGBColor
    {
        Color GetColorFromRGBWithAdapter(float r, float g, float b);
    }
}

