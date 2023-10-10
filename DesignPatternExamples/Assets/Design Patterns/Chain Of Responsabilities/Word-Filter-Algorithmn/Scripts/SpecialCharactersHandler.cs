using System.Text;
using System.Text.RegularExpressions;

public class SpecialCharactersHandlers : BaseRuleHandler
{
    readonly string allowedCharactersRegex = @"[a-zA-Z]";

    public override string CheckRuleOnSentence(string sentence)
    {
        StringBuilder stringBuilder = new();

        foreach (string word in sentence.Split(' '))
        {
            foreach (char character in word)
            {
                if (!Regex.IsMatch(character.ToString(), allowedCharactersRegex))
                {
                    stringBuilder.Append($"The character ({character}) is a special characters on ({word}) word and isn't valid.");
                }
            }
        }

        if (stringBuilder.Length == 0)
        {
            stringBuilder.Append($"The sentence ({sentence}) has no special characters.");
        }

        string sentenceLog = stringBuilder.ToString() + "\n" + base.CheckRuleOnSentence(sentence);
        return sentenceLog;
    }
}