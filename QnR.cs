using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgramming
{
    public class QnR
    {
        public static void FindQnR()
        {
            Console.WriteLine("Enter the divident");
            int divident = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the divisor");
            int divisor = Convert.ToInt32(Console.ReadLine());

            int quotient = divident / divisor;
            int remainder = divident % divisor;

            Console.WriteLine("Quotient is : " + quotient);
            Console.WriteLine("Remainder is : "+remainder);
        }
    }
}
