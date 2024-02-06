using System.Text;

namespace ChainOfResponsabilities
{
    public class CharactersCountHandler : BaseRuleHandler
    {
        public override string CheckRuleOnSentence(string sentence)
        {
            StringBuilder stringBuilder = new()
            {
                Capacity = 54
            };


            if (sentence.Length > stringBuilder.Capacity)
            {
                stringBuilder.Append($"The sentence ({sentence}) has more than 54 characters.");
            }
            else
            {
                stringBuilder.Append($"The sentence ({sentence}) has correctly amount of characters.");
            }

            string sentenceLog = stringBuilder.ToString() + "\n" + base.CheckRuleOnSentence(sentence);

            return sentenceLog;
        }
    }
}