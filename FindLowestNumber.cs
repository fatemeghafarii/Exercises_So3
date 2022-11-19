using System;

namespace Test2
{
    internal class FindLowestNumber
    {
        static void Main(string[] args)
        {
            int num1, num2, num3, num4, num5;

            Console.WriteLine("Enter 5 number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());
            num3 = Convert.ToInt32(Console.ReadLine());
            num4 = Convert.ToInt32(Console.ReadLine());
            num5 = Convert.ToInt32(Console.ReadLine());

            int min = num1;

            if (min > num2)
                min = num2;
            if (min > num3)
                min = num3;
            if (min > num4)
                min = num4;
            if (min > num5)
                min = num5;

            Console.WriteLine(min);
        }
    }
}
