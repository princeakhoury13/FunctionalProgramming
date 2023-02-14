using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgramming
{
    public class LargestNumber
    {
        public static void FindLargest()
        {
            Console.WriteLine("Enter the first number");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the third number");
            int num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine("The greatest number is : "+num1);

            }
            else if (num2 > num1 && num2 > num3)
            {
                Console.WriteLine("The greatest number is : " + num2);
            }
            else
            {
                Console.WriteLine("The greatest number is : " + num3);
            }
        }
    }
}
