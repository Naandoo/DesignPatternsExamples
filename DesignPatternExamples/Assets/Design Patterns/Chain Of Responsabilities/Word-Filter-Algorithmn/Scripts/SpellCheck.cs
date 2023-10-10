using System.Collections.Generic;

public class SpellCheck
{
    private IRuleHandler SpecialCharactersHandler = new SpecialCharactersHandlers();
    private IRuleHandler CharactersCountHandler = new CharactersCountHandler();
    private List<string> sentencesToCheck = new List<string>
    {
        "Qual o estado mais perigosó do Brasil?",
        "Video game mais famoso da empresa Nintendo",
        "Nome da ciência que estuda os angulos das geometrias",
    };

    private string SpellCheckLog = " ";

    public void Init() => SetOrderOfChain();

    private void SetOrderOfChain()
    {
        SpecialCharactersHandler.SetNext(CharactersCountHandler);

        VerifySentences();
    }

    private void VerifySentences()
    {
        foreach (string sentence in sentencesToCheck)
        {
            AddLog(SpecialCharactersHandler.CheckRuleOnSentence(sentence));
        }

        UnityEngine.Debug.Log(SpellCheckLog);
    }

    public void AddLog(string Log) => SpellCheckLog += Log;

}