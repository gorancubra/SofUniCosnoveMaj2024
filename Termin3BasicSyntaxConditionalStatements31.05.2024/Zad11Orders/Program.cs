using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad11Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ordersCount = int.Parse(Console.ReadLine());
            double sum = 0;

            for (int i=1; i<=ordersCount; i++)
            {
                double capsulePrice = double.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                int capsuleCount = int.Parse(Console.ReadLine());

                double price = (days * capsuleCount) * capsulePrice;

                Console.WriteLine($"The price for the coffee is: ${price:F2}");

                sum += price;
                price = 0;

            }

            Console.WriteLine($"Total: ${sum:F2}");
        }
    }
}
