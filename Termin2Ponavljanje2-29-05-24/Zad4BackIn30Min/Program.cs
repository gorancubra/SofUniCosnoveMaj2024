using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad4BackIn30Min
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hours = Convert.ToInt32(Console.ReadLine());
            int minutes = Convert.ToInt32(Console.ReadLine());

            minutes += 30;

            if(minutes > 59)
            {
                hours++;
                minutes -= 60;
            }

            if (hours > 23)
                hours = 0;

            Console.WriteLine("{0}:{1:D2}", hours, minutes);


        }
    }
}
