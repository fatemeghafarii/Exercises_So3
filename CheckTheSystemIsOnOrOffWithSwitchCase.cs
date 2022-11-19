using System;

namespace Test2
{
    internal class CheckTheSystemIsOnOrOffWithSwitchCase
    {
        static void Main(string[] args)
        {
            //first solution
            Console.Write("Is there current?(yes = y & no = n): ");
            char current = Console.ReadKey().KeyChar;
            Console.WriteLine();


            Console.Write("Is there healthy?(yes = y & no = n): ");
            char healthy = Console.ReadKey().KeyChar;
            Console.WriteLine();

            bool isOn = false;

            switch (current, healthy)
            {
                case ('y', 'y'):
                    isOn = true;
                    break;
                default:
                    isOn = false;
                    break;
            }
            Console.WriteLine(isOn);

            //second solution
            //Console.Write("Is there current?(yes = Y & no = N): ");
            //char current = Console.ReadKey().KeyChar;
            //int currentBool = Convert.ToInt32(current);
            //Console.WriteLine();


            //Console.Write("Is there healthy?(yes = Y & no = N): ");
            //char healthy = Console.ReadKey().KeyChar;
            //int healthyBool = Convert.ToInt32(healthy);
            //Console.WriteLine();

            //bool isOn = false;

            ////if (currentBool == 89 && healthyBool == 89)
            ////    isOn = true;

            ////Console.WriteLine();
            ////Console.WriteLine(isOn);

            //switch (currentBool, healthyBool)
            //{
            //    case (89, 89):
            //        Console.WriteLine(isOn = true);
            //        break;
            //    default:
            //        Console.WriteLine(isOn = false);
            //        break;
            //}
        }
    }
}
