using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace palindrome_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            int reversedNumber = 0, remainder, originalNumber = number;

            while (number != 0)
            {
                remainder = number % 10;
                reversedNumber = reversedNumber * 10 + remainder;
                number /= 10;
            }

            if (originalNumber == reversedNumber)
            {
                Console.WriteLine("The number {0} is a palindrome.", originalNumber);
            }
            else
            {
                Console.WriteLine("The number {0} is not a palindrome.", originalNumber);
            }
            Console.ReadLine();
        }
    }
}
