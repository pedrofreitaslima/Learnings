using System.Collections.Generic;

namespace ConsoleUI
{
    public class VariableReference : Expression
    {
        string _name;
        public VariableReference(string name) => (this._name) = (name);
        public override double Evaluate(Dictionary<string, object> vars)
        {
            object value = vars[this._name] ?? throw new System.Exception($"Unkown variable: { this._name}");
            return System.Convert.ToDouble(value);
        }
    }
}
