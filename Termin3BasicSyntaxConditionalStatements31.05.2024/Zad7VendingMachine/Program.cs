using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad7VendingMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double coins = 0;
            string product = "";

            double nutsPrice = 2.0;
            double waterPrice = 0.7;
            double crispsPrice = 1.5;
            double sodaPrice = 0.8;
            double cokePrice = 1.0;

            do
            {
                string start = Console.ReadLine();

                if (start.Equals("Start"))
                {
                    break;
                }
                double insert = double.Parse(start);

                if (insert==0.1 || insert==0.2 || insert==0.5 || insert==1 || insert==2)
                {
                    coins += insert;
                }
                else
                {
                    Console.WriteLine("Cannot accept {0}", insert);
                }

            } while (true);

            product = Console.ReadLine();

            while (!product.Equals("End"))
            {
                switch(product)
                {
                    case "Nuts":
                        if (coins >= nutsPrice)
                        {
                            Console.WriteLine($"Purchased nuts");
                            coins -= nutsPrice;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;

                    case "Water":
                        if (coins >= waterPrice)
                        {
                            Console.WriteLine($"Purchased water");
                            coins -= waterPrice;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;

                    case "Crisps":
                        if (coins >= crispsPrice)
                        {
                            Console.WriteLine($"Purchased crisps");
                            coins -= crispsPrice;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;

                    case "Soda":
                        if (coins >= sodaPrice)
                        {
                            Console.WriteLine($"Purchased soda");
                            coins -= sodaPrice;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;

                    case "Coke":
                        if (coins >= cokePrice)
                        {
                            Console.WriteLine($"Purchased coke");
                            coins -= cokePrice;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;

                    default:
                        Console.WriteLine("Invalid product");
                        break;
                }

                product = Console.ReadLine();
            }
            Console.WriteLine($"Change: {coins:F2}");
        }
    }
}
