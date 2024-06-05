using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad2PoundsToDollars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double pounds = Convert.ToDouble(Console.ReadLine());
            double dollars = pounds * 1.31f;

            Console.WriteLine($"{dollars:F3}");
           
            
        }
    }
}
