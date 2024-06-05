using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad12EvenNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            while (true)
            {
                int number = Convert.ToInt32(Console.ReadLine());

                if (number % 2 != 0)
                {
                    Console.WriteLine("Please write an even number.");
                }
                else
                {
                    Console.WriteLine("The number is: {0}", Math.Abs(number));
                    break;
                }
            }


        }
    }
}
