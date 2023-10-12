using UnityEngine;

public class ChatBallonPool : MonoBehaviour
{
    #region Private Variables
    [SerializeField] private BallonHolder _firstCharacterChatBallonPrefab;
    [SerializeField] private BallonHolder _secondCharacterChatBallonPrefab;
    [SerializeField] private BallonHolder _thirdCharacterChatBallonPrefab;
    #endregion

    #region Public Variables
    private PoolSystem<BallonHolder> _firstCharacterChatBallon;
    private PoolSystem<BallonHolder> _secondCharacterChatBallon;
    private PoolSystem<BallonHolder> _thirdCharacterChatBallon;
    #endregion

    private void Awake() => CreatePoolOfObjects();

    private void CreatePoolOfObjects()
    {
        _firstCharacterChatBallon = new PoolSystem<BallonHolder>(_firstCharacterChatBallonPrefab, 10, transform);
        _secondCharacterChatBallon = new PoolSystem<BallonHolder>(_secondCharacterChatBallonPrefab, 10, transform);
        _thirdCharacterChatBallon = new PoolSystem<BallonHolder>(_thirdCharacterChatBallonPrefab, 10, transform);
    }

    public BallonHolder Get(CharacterType characterType)
    {
        return characterType switch
        {
            CharacterType.FirstCharacter => _firstCharacterChatBallon.Get(),
            CharacterType.SecondCharacter => _secondCharacterChatBallon.Get(),
            CharacterType.ThirdCharacter => _thirdCharacterChatBallon.Get(),
            _ => null,
        };
    }
}

public enum CharacterType
{
    FirstCharacter,
    SecondCharacter,
    ThirdCharacter
}