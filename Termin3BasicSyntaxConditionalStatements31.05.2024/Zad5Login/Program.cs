using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad5Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pass = Console.ReadLine();
            string reversed = "";
            int counter = 0;

            for (int i=pass.Length-1; i >= 0; i--)
            {
                reversed += pass[i];
            }

            while (counter < 4)
            {
                string enter = Console.ReadLine();

                if (enter.Equals(reversed))
                {
                    Console.WriteLine($"User {pass} logged in.");
                    break;
                }

                else
                {
                    counter++;
                    if (counter == 4)
                    {
                        Console.WriteLine($"User {pass} blocked!");
                        break;
                    }
                    Console.WriteLine($"Incorrect password. Try again.");
                    
                }
            }
           
        }
    }
}
