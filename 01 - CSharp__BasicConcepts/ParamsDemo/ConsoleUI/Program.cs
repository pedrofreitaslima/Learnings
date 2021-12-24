using System;

namespace ConsoleUI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int i = 2, j = 3;

            Console.WriteLine("Test with reference Swap");
            Console.WriteLine($"{i},{j}");
            SwapTest.Swap(ref i,ref j);
            Console.WriteLine($"{i},{j}");

            Console.WriteLine();
            Console.WriteLine("Test with output Divide");
            int x = 10, y = 5;
            DivideTest.Divide(x, y, out int result, out int remainder);
            Console.WriteLine($"The result of calc {x}/{y} is {result} and your remainder is {remainder}");

        }
    }
}
