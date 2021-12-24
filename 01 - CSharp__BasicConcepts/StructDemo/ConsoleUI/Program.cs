using System;

namespace ConsoleUI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Structure example");
            CoordsStruct coords1 = new CoordsStruct(10, 10);
            CoordsStruct coords2 = coords1;
            coords1.Latitude = 20;
            Console.WriteLine(String.Format("Coords principal is {0}", coords1.View()));
            Console.WriteLine(String.Format("Coords secundary is {0}", coords2.View()));
            /*
                Structs are value types, allocated either on the stack or inline in containing types.
                Allocations and de-allocations of value types are in general cheaper than allocations and de-allocations of reference types.
                In structs, each variable contains its own copy of the data (except in the case of the ref and out parameter variables), and an operation on one variable does not affect another variable.
            */

            Console.WriteLine("Class example");
            CoordsClass coords3 = new CoordsClass(10, 10);
            CoordsClass coords4 = coords3;
            coords3.Latitude = 20;
            Console.WriteLine(String.Format("Coords principal is {0}", coords3.View()));
            Console.WriteLine(String.Format("Coords secundary is {0}", coords4.View()));
            /*
                Classes are reference types, allocated on the heap and garbage-collected. 
                Assignments of large reference types are cheaper than assignments of large value types.
                In classes, two variables can contain the reference of the same object and any operation on one variable can affect another variable.
            */
        }
    }
}
