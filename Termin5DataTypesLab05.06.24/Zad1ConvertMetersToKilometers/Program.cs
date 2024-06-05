using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad1ConvertMetersToKilometers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int meters = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{((double)meters/1000):F2}");
        }
    }
}
