using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgramming
{
    public class EvenOdd
    {
        public static void EvenOrOdd()
        {
            Console.WriteLine("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("The given number is Even!");
            }
            else
            {
                Console.WriteLine("The given number is Odd!");
            }
        }
    }
}
