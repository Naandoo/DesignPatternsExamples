using UnityEngine;

public class SpellCheckProgram : MonoBehaviour
{
    private void Start()
    {
        SpellCheck spellCheck = new SpellCheck();
        spellCheck.Init();
    }
}
