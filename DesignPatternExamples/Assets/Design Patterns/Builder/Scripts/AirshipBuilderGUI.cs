using UnityEngine;

namespace Builder
{
    public class AirshipBuilderGUI : MonoBehaviour
    {
        [SerializeField] private AirshipBuilder airshipBuilder;

        // public void ToggleWing(bool value) => value ? airshipBuilder.AddWing() : airshipBuilder.Undo();
        // public void ToggleWeapon(bool value) => value ? airshipBuilder.AddWeapon() : airshipBuilder.Undo();
    }
}