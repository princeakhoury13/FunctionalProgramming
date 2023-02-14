using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgramming
{
    public class Swap
    {
        public static void SwapNumbers()
        {
            Console.WriteLine("Enter value of 1st number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value of 2nd number");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Before swapping: a = " + a + ", b = " + b);

            a = a + b; // a = 15
            b = a - b; // b = 5
            a = a - b; // a = 10

            Console.WriteLine("After swapping: a = " + a + ", b = " + b);
        }
    }
}
