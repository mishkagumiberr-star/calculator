using System;
namespace Calculator
{
    class CalculatorLogic
    {
        public float number1;
        public float number2;
        public string choosenumber1 = "first number: ";
        public string choosenumber2 = "second number: ";
        public void Addition()
        {
            float result1 = number1 + number2;
            Console.WriteLine($"result {result1}");
        }
        public void Subtraction()
        {
            float result2 = number1 - number2;
            Console.WriteLine($"result {result2}");
        }
        public void Multiplication()
        {
            float result3 = number1 * number2;
            Console.WriteLine($"result {result3}");
        }
        public void Division()
        {
            float result4 = number1 / number2;
            Console.WriteLine($"result {result4}");
        }
        public void Question()
        {
            Console.Write($"{choosenumber1}");
            if (!float.TryParse(Console.ReadLine(), out number1))
            {
                Console.WriteLine("write number");
                return;
            }
            Console.Write($"{choosenumber2}");
            if (!float.TryParse(Console.ReadLine(), out number2))
            {
                Console.WriteLine("write number");
                return;
            }
        }
    }
}
