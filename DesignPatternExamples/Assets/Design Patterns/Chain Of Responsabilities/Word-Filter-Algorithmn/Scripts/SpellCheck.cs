using UnityEngine;

public class SpellCheck : MonoBehaviour
{
    [SerializeField] private ChatHandler _chatHandler;
    private IRuleHandler SpecialCharactersHandler = new SpecialCharactersHandlers();
    private IRuleHandler CharactersCountHandler = new CharactersCountHandler();
    private string SpellCheckLog = string.Empty;

    private void Awake() => SetOrderOfChain();
    private void SetOrderOfChain() => SpecialCharactersHandler.SetNext(CharactersCountHandler);

    public void VerifySentence(string sentence)
    {
        AddLog(SpecialCharactersHandler.CheckRuleOnSentence(sentence));

        _chatHandler.AddChatBallon(SpellCheckLog, CharacterType.SecondCharacter);

        CleanLog();
    }

    private void CleanLog() => SpellCheckLog = string.Empty;
    public void AddLog(string Log) => SpellCheckLog += Log;
}