using System;

namespace Zad6StrongNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            int sum = 0;

            for (int i = 0; i < number.Length; i++)
            {
                int n = Convert.ToInt32(number[i] - '0');
                int singleSum = Faktorijel(n);
                sum += singleSum;
            }

            if (int.Parse(number).Equals(sum))
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }

        public static int Faktorijel(int n)
        {
            if (n == 0) 
                return 1;
            else
                return n * Faktorijel(n - 1); 
        }
    }
}
