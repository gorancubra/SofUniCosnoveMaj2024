using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006_StrongNumber
{
    class Program
    {
        /*
        Write a program that receives a single integer and calculates if it's strong or not. A number is strong, if the sum of the factorials of each digit is equal to the number itself.
        Example: 145 is a strong number, because 1! + 4! + 5! = 145. 
        Print "yes", if the number is strong and "no", if the number is not strong.
        */

        static void Main(string[] args)
        {
            int userInput = int.Parse(Console.ReadLine());
            var digits = GetDigits(userInput);
            var sum = FactorialSum(digits);

            Console.WriteLine(NumbersAreEqual(userInput, sum));
        }

        static string NumbersAreEqual(int a, int b)
        {
            string outputString;
            if (Equals(a, b))
            {
                outputString = "yes";
            }
            else
            {
                outputString = "no";
            }
            return outputString;
        }

        static int[] GetDigits(int number)
        {
            int numberCopy = number;
            List<int> digitsList = new List<int>();

            while (number > 0)
            {
                digitsList.Add(number % 10);
                number /= 10;
            }

            return digitsList.ToArray();
        }

        static int FactorialSum(int[] digits)
        {
            int output = 0;
            foreach (var obj in digits)
            {
                output += CalculateFactorial(obj);
            }
            return output;
        }


        static int CalculateFactorial(int number)
        {
            int output = 1;
            for (int i = number; i > 1; i--)
            {
                output= i;
            }
            return output;
        }
    }
} 
