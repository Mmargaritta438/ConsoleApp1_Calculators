using System;

namespace ConsoleApp1_Calculators
{
    class Program
    {
        //private static double m1, m2;
        static void Main(string[] args)
        {
            //Console.ForegroundColor = ConsoleColor.Yellow;
            //Console.WriteLine("Write number 1: ");
            //m1 = Convert.ToDouble(Console.ReadLine());
            //Console.ForegroundColor = ConsoleColor.Yellow;
            //Console.WriteLine("Write number 2: ");
            //m2 = Convert.ToDouble(Console.ReadLine());
            //Console.ForegroundColor = ConsoleColor.Green;
            //Console.WriteLine($"Your result: {m1}+{m2} = " + (m1 + m2));
            //Console.WriteLine($"Your result: {m1}-{m2} = " + (m1 - m2));
            //Console.WriteLine($"Your result: {m1}*{m2} = " + (m1 * m2));
            //Console.WriteLine($"Your result: {m1}/{m2} = " + (m1 / m2));
            //Console.ForegroundColor = ConsoleColor.Magenta;
            //Console.WriteLine("press any key for close app");
            //Console.ReadKey(true);


            double m1 = 0;
            double m2 = 0;
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Hello in first calculator");

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("write first number and press ENTER");
            m1 = Convert.ToDouble(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("write second number and press ENTER");
            m2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Choose an option from list:");
            Console.WriteLine("\t+ - Add");
            Console.WriteLine("\t- - Subtract");
            Console.WriteLine("\t* - multiply");
            Console.WriteLine("\t/ - Dividde");
            Console.WriteLine("\t% - % of numbeer");
            Console.WriteLine("Your choice");

            switch (Console.ReadLine())
            {
                case "+":
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Your result: {m1}+{m2} = " + (m1 + m2));
                    break;
                case "-":
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Your result: {m1}-{m2} = " + (m1 - m2));
                    break;
                case "*":
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Your result: {m1}*{m2} = " + (m1 * m2));
                    break;
                case "/":
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Your result: {m1}/{m2} = " + (m1 / m2));
                    break;
                case "%":
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Your result: {m1} of number {m2} = " + (m1*m2/100));
                    break;
            }

        }
    }

}