using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad5SpecijalNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int ostatak;
            int osnova;

            for (int i=1; i<=n; i++)
            {
                int sum = 0;
                osnova = i;

                while (osnova > 0)
                {
                    ostatak = osnova % 10;
                    osnova = osnova / 10;
                    sum += ostatak;
                }

                if(sum  == 5 || sum  == 7 || sum  == 11)
                {
                    Console.WriteLine($"{i} -> True");
                }
                else
                {
                    Console.WriteLine($"{i} -> False");
                }
                
            }
        }
    }
}
