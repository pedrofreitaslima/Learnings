using System.Collections.Generic;

namespace ConsoleUI
{
    public class Constant : Expression
    {
        double _value;
        public Constant(double value) => (this._value) = value;
        public override double Evaluate(Dictionary<string, object> vars) { return _value; }
    }
}
