using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgramming
{
    public class HarmonicNumbers
    {
        public static void PrintHarmonics()
        {
            Console.WriteLine("Enter the value of N: ");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n <= 0)
            {
                Console.WriteLine("N should be a positive integer and non-zero.");
                return;
            }

            double harmonicValue = 0;
            double divisor = 1;
            for (int i = 1; i <= n; i++)
            {
                harmonicValue += divisor / i;
            }

            Console.WriteLine("The " + n + "th harmonic value is: " + harmonicValue);
        
        }
    }
}
