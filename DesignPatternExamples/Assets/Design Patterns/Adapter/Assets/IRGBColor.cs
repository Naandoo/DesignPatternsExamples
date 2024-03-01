using UnityEngine;

namespace Adapter
{
    public interface IRGBColor
    {
        Color GetColorFromRGBWithAdapter(int r, int g, int b);
    }
}

