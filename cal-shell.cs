using System;
namespace Calculator
{
    class CalculatorShell
    {
        static void Main()
        {
            CalculatorLogic cal1 = new CalculatorLogic();
            while (true)
            {
                Console.WriteLine("calculator v1.0");
                Console.WriteLine("------------------");
                Console.WriteLine("What do you want to do?:");
                Console.WriteLine("1. addition");
                Console.WriteLine("2. subtraction");
                Console.WriteLine("3. multiplication");
                Console.WriteLine("4. division");
                Console.WriteLine("5. exit");
                Console.WriteLine("------------------");
                Console.Write("choose a number: ");
                string? choose = Console.ReadLine()?.ToString();
                if (choose == "1")
                {
                    cal1.Question();
                    cal1.Addition();
                    Console.WriteLine("press any key");
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (choose == "2")
                {
                    cal1.Question();
                    cal1.Subtraction();
                    Console.WriteLine("press any key");
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (choose == "3")
                {
                    cal1.Question();
                    cal1.Multiplication();
                    Console.WriteLine("press any key");
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (choose == "4")
                {
                    cal1.Question();
                    cal1.Division();
                    Console.WriteLine("press any key");
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (choose == "5")
                {
                    return;
                }
                else
                {
                    Console.WriteLine("idk");
                }
            }
        }
    }
}