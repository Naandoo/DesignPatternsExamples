namespace ChainOfResponsabilities

{
    public abstract class BaseRuleHandler : IRuleHandler
    {
        private IRuleHandler _nextRuleHandler;

        public IRuleHandler SetNext(IRuleHandler ruleHandler)
        {
            this._nextRuleHandler = ruleHandler;
            return ruleHandler;
        }

        public virtual string CheckRuleOnSentence(string sentence)
        {
            if (this._nextRuleHandler != null)
            {
                return this._nextRuleHandler.CheckRuleOnSentence(sentence);
            }
            else
            {
                return " ";
            }
        }
    }
}