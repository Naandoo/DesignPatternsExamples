using UnityEngine;

namespace Adapter
{
    public interface IHexadecimalColor
    {
        Color ConvertHexToRGB(string hexCode);
    }
}