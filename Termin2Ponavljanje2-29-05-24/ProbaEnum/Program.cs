using System;

enum Month
{
    January = 1,
    February,
    March,
    April,
    May,
    June,
    July,
    August,
    September,
    October,
    November,
    December
}

class Program
{
    static void Main(string[] args)
    {
        int monthNumber = int.Parse(Console.ReadLine());
       
            if (monthNumber >= 1 && monthNumber <= 12)
            {
                Console.WriteLine((Month)monthNumber);
            }
            else
            {
                Console.WriteLine("Error!");
            }
    }
}
