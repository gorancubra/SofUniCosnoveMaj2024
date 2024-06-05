using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad3Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int peopleCount = int.Parse(Console.ReadLine());
            string groupType = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();

            double price = 0;

            if (dayOfWeek.Equals("Friday"))
            {
                if (Equals(groupType, "Students"))
                    price = 8.45;
                else if (Equals(groupType, "Business"))
                    price = 10.90;
                else if (Equals(groupType, "Regular"))
                    price = 15;
            }

            else if (dayOfWeek.Equals("Saturday"))
            {
                if (Equals(groupType, "Students"))
                    price = 9.80;
                else if (Equals(groupType, "Business"))
                    price = 15.60;
                else if (Equals(groupType, "Regular"))
                    price = 20;
            } 

            else if (dayOfWeek.Equals("Sunday"))
            {
                if (Equals(groupType, "Students"))
                    price = 10.46;
                else if (Equals(groupType, "Business"))
                    price = 16;
                else if (Equals(groupType, "Regular"))
                    price = 22.50;
            }

            if(groupType.Equals("Students"))
            {
                if (peopleCount >= 30)
                    price = price * peopleCount * 0.85;
                else
                    price *= peopleCount;
            }
            else if (groupType.Equals("Business"))
            {
                if (peopleCount >= 100)
                    price = price * (peopleCount-10);
                else
                    price *= peopleCount;
            }
            else if (groupType.Equals("Regular"))
            {
                if (peopleCount >= 10 && peopleCount <= 20)
                    price = price * peopleCount * 0.95;
                else
                    price *= peopleCount;
            }

            Console.WriteLine("Total price: {0:F2}", price);
        }
    }
}
