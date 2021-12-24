using System.Collections.Generic;

namespace ConsoleUI
{
    public abstract class Expression
    {
        public abstract double Evaluate(Dictionary<string, object> vars);
    }
}
