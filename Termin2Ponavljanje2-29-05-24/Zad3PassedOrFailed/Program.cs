using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad3PassedOrFailed
{
    internal class Program
    {
        static void Main(string[] args)
        {

            float grade = float.Parse(Console.ReadLine());

            if (grade >= 3.0)
                Console.WriteLine("Passed!");
            else
                Console.WriteLine("Failed!");
        }
    }
}
