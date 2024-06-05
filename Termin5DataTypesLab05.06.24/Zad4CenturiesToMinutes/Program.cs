using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad4CenturiesToMinutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int centuries = int.Parse(Console.ReadLine());

            int years = centuries * 100;

            double days = Math.Floor((double)years * 365.2422);

            decimal hours = (decimal)days * 24;
            decimal minutes = hours * 60;

            // Console.WriteLine(years);
            //Console.WriteLine(days);
            //Console.WriteLine(hours);
            //Console.WriteLine(minutes);
            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes");
        }
    }
}
