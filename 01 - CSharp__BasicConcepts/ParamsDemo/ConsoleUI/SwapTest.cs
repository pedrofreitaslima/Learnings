using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class SwapTest
    {
        public static void Swap(ref int x, ref int y)
        {
            int temp = y;
            y = x;
            x = temp;
        }
    }
}
