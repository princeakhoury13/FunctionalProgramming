using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgramming
{
    public class Factors
    {
        public static void FindFactors()
        {
            Console.WriteLine("Enter a number to find its prime factors:");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Prime factors of " + n + ": ");

            
            for (int i = 2; i * i <= n; i++)
            {
                
                while (n % i == 0)
                {
                    Console.Write(i + " ");
                    n /= i;
                }
            }

            if (n > 1)
            {
                Console.Write(n);
            }

            
        }
    }
}
