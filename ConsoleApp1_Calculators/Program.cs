using System;

namespace ConsoleApp1_Calculators
{
    class Program
    {
        private static double m1, m2;
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Write number 1: ");
            m1 = Convert.ToDouble(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Write number 2: ");
            m2 = Convert.ToDouble(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Your result: {m1}+{m2} = " + (m1 + m2));
            Console.WriteLine($"Your result: {m1}-{m2} = " + (m1 - m2));
            Console.WriteLine($"Your result: {m1}*{m2} = " + (m1 * m2));
            Console.WriteLine($"Your result: {m1}/{m2} = " + (m1 / m2));
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("press any key for close app");
            Console.ReadKey(true);
        }
    }

}