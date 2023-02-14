using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgramming
{
    public class Vowels
    {
        public static void CheckVowel()
        {
            char c;
            Console.WriteLine("Enter any character:");
            c = Convert.ToChar(Console.ReadLine());

            if (c == 'A' || c == 'E' || c == 'I' || c == 'U' || c == 'o' || c == 'a' || c == 'e' || c == 'i' || c == 'u' || c == 'O')
            {
                Console.WriteLine("That is a Vowel!");
            }
            else if (c >= 'A' && c <= 'Z' || c >= 'a' && c <= 'z')
            {
                Console.WriteLine("That is a consonant!");
            }
            else
            {
                Console.WriteLine("Please enter a valid character :) ");
            }
        }
    }
}
