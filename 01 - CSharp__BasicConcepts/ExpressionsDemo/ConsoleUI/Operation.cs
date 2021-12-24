using System.Collections.Generic;

namespace ConsoleUI
{
    public class Operation : Expression
    {
        Expression _left;
        char _op;
        Expression _right;

        public Operation(Expression left, char op, Expression right) => (this._left , this._op, this._right) = (left, op, right);
        
        public override double Evaluate(Dictionary<string,object> vars)
        {
            double x = _left.Evaluate(vars);
            double y = _right.Evaluate(vars);
            switch (this._op)
            {
                case '+': return x + y;
                case '-': return x - y;
                case '*': return x * y;
                case '/': return x / y;
                default: throw new System.Exception($"Unknown operator: {this._op}");
            }
        }
    }
}
