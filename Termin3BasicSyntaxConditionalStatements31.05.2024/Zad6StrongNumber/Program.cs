using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad6StrongNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            int sum = 0;

            for (int i=0; i<number.Length; i++)
            {
                int n = Convert.ToInt32(number[i] - '0');
                int singleSum = 1;

                if (n == 0)
                {
                    singleSum = 1;
                }
                else
                {
                    for (int j = n; j > 0; j--)
                    {
                        singleSum *= j;
                    }
                }

                sum += singleSum;
                
            }

            if(int.Parse(number).Equals(sum))
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
