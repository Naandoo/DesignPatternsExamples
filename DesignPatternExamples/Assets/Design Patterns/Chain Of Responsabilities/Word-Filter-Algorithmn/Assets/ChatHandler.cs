using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ChainOfResponsabilities
{
    public class ChatHandler : MonoBehaviour
    {
        [SerializeField] private ChatBallonPool _chatBallonPool;
        [SerializeField] private VerticalLayoutGroup _chatContent;
        [SerializeField] private TMP_InputField _inputField;
        [SerializeField] private SpellCheck _spellCheck;

        public void CheckChatMessage()
        {
            string message = _inputField.text.Trim();

            if (message.Length > 0)
            {
                AddChatBallon(message, CharacterType.ThirdCharacter);
                _spellCheck.VerifySentence(message);
                _inputField.text = string.Empty;
            }
        }

        public void AddChatBallon(string message, CharacterType characterType)
        {
            BallonHolder chatBallon = _chatBallonPool.Get(characterType);
            chatBallon.transform.SetParent(_chatContent.transform);
            chatBallon.transform.localScale = Vector3.one;
            SetBallonMessage(chatBallon, message);
        }

        private void SetBallonMessage(BallonHolder chatBallon, string message) => chatBallon.BallonText.text = message;

    }
}
