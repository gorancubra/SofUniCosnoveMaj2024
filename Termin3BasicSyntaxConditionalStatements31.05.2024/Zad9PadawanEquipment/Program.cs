using System;


namespace Zad9PadawanEquipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double money = Convert.ToDouble(Console.ReadLine());
            int students = Convert.ToInt32(Console.ReadLine());

            double lightsabersPrice = Convert.ToDouble(Console.ReadLine());
            double robesPrice = Convert.ToDouble(Console.ReadLine());
            double beltsPrice = Convert.ToDouble(Console.ReadLine());

            double totalLight = Math.Ceiling(students * 1.1) * lightsabersPrice;
            double totalRobe = robesPrice * students;

            int umanjenje = students / 6;
            double totalBeltsPrice = (students - umanjenje) * beltsPrice;

            double total = totalLight + totalRobe + totalBeltsPrice;


            if (money >= total)
            {
                Console.WriteLine($"The money is enough - it would cost {total:F2} USD.");
            }
            else
            {
                Console.WriteLine($"John will need {total-money:F2} USD more.");
            }
        }
    }
}
