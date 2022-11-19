using System;

namespace Test2
{
    internal class CalculatorWithFunction
    {
        static void Main(string[] args)
        {
            Sum(2, 3);
            Sub(2, 3);
            Mull(2, 3);
            Division(2, 3);
        }
        public static void Sum(int firstNumber, int secondNumber)
        {
            int result = firstNumber + secondNumber;
            Console.WriteLine($"Result sum is: {result}");
        }
        public static void Sub(int firstNumber, int secondNumber)
        {
            int result = firstNumber - secondNumber;
            Console.WriteLine($"Result sub is: {result}");
        }
        public static void Mull(int firstNumber, int secondNumber)
        {
            int result = firstNumber * secondNumber;
            Console.WriteLine($"Result mull is: {result}");
        }
        public static void Division(int firstNumber, double secondNumber)
        {
            double result = firstNumber / secondNumber;
            Console.WriteLine($"Result divistion is: {result}");
        }
    }
}
