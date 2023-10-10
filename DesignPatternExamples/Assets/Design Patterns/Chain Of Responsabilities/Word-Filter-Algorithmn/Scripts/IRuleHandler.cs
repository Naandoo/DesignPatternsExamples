public interface IRuleHandler
{
    IRuleHandler SetNext(IRuleHandler ruleHandler);
    string CheckRuleOnSentence(string sentence);
}