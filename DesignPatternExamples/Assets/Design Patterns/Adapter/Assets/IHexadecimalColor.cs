using UnityEngine;

namespace Adapter
{
    public interface IHexadecimalColor
    {
        Color GetColorFromHex(string hexCode);
    }
}