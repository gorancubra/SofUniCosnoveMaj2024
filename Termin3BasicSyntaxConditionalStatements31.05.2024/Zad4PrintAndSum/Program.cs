﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad4PrintAndSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startNum = int.Parse(Console.ReadLine());
            int endNum = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i=startNum; i<=endNum; i++)

            {
                Console.Write(i + " ");
                sum += i;
            }

            Console.WriteLine($"\nSum: {sum}");
        }
    }
}