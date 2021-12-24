using System;

namespace ConsoleUI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var s = new Stack<int>();
            s.Push(1);
            s.Push(10);
            s.Push(100);
            s.Push(1000);
            s.Push(10000);
            Console.WriteLine(s.Pop());
            Console.WriteLine(s.Pop());
            Console.WriteLine(s.Pop());
            Console.WriteLine(s.Pop());
        }
    }
}
