using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ChatHandler : MonoBehaviour
{
    [SerializeField] private ChatBallonPool _chatBallonPool;
    [SerializeField] private VerticalLayoutGroup _chatContent;
    [SerializeField] private TMP_InputField _inputField;
    [SerializeField] private SpellCheck _spellCheck;

    public void AddChatBallon(string message, CharacterType characterType)
    {
        BallonHolder chatBallon = _chatBallonPool.Get(characterType);
        chatBallon.transform.SetParent(_chatContent.transform);
        _chatContent.CalculateLayoutInputVertical();
        _chatContent.SetLayoutVertical();
        SetBallonMessage(chatBallon, message);
    }


    private void SetBallonMessage(BallonHolder chatBallon, string message) => chatBallon.BallonText.text = message;

    public void CheckChatMessage()
    {
        AddChatBallon(_inputField.text, CharacterType.ThirdCharacter);

        if (_inputField.text != string.Empty)
        {
            _spellCheck.VerifySentence(_inputField.text);
        }
    }
}
