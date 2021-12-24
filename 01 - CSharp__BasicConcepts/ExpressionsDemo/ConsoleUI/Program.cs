using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Expression e = new Operation(
                new VariableReference("x"), '*', new Operation(
                    new VariableReference("y"), '+', new Constant(2)));
            Dictionary<string, object> vars = new Dictionary<string, object>();
            vars["x"] = 3;
            vars["y"] = 4;
            Console.WriteLine(e.Evaluate(vars));
            vars["x"] = 1.7;
            vars["y"] = 9;
            Console.WriteLine(e.Evaluate(vars));
        }
    }
}
