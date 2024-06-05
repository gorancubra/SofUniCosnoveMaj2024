using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Termin5DataTypesLab05._06._24
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double a = 1.0f, b = 0.33f, sum = 1.33f;
            //Console.WriteLine(a.GetType());

            Console.WriteLine("a+b={0} sum={1} equal={2}", a + b, sum, (a + b == sum));

            double one = 0;

            for (int i = 0; i < 10000; i++) 
                one += 0.0001;

            Console.WriteLine(one);

            Console.WriteLine(10 / 0.0);
            Console.WriteLine(-10 / 0.0);
            Console.WriteLine(0 / 0.0);

            char ch = 'a';
            Console.WriteLine("The code of '{0}' is: {1}", ch, (int)ch);

            //int n = int.Parse(Console.ReadLine());

            //decimal sum1 = 0;

            //for (int i = 0; i < n; i++)

            //    sum1 += decimal.Parse(Console.ReadLine());

            //Console.WriteLine(sum1);

        }
    }
}
