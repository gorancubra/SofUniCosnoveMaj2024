using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad10RageExpences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lostGameCount = int.Parse(Console.ReadLine());
            double headSetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            int headsetCount = 0;
            int mouseCount = 0;
            int keyboardCount = 0;
            int displayCount = 0;

            for (int i=1; i<=lostGameCount; i++)
            {
                if (i%2 == 0)
                {
                    headsetCount++;
                }

                if (i % 3 == 0)
                {
                    mouseCount++;
                }

                if (i % 6 == 0)
                {
                    keyboardCount++;

                    if (keyboardCount%2 == 0)
                    {
                        displayCount++;
                    }
                }
            }

            double rageExpences = headsetCount * headSetPrice + mouseCount * mousePrice + keyboardCount * keyboardPrice + displayCount * displayPrice;

            Console.WriteLine($"Rage expenses: {rageExpences:F2} USD");
        }
    }
}
