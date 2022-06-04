using System;

namespace _19._02_20._02
{
    class Program
    {
        static void Main()
        {
            //Input
            string name = Console.ReadLine();
            //Actions
            switch (name)
            {
                case "banana":
                case "apple":
                case "kiwi":
                case "cherry":
                case "lemon":
                case "grapes":
                    Console.WriteLine("fruit");
                    break;
                case "tomato":
                case "cucumber":
                case "pepper":
                case "carrot":
                    Console.WriteLine("vegetable");
                    break;
                default:
                    Console.WriteLine("unknown");
                    break;
            }
            //Output




        }
    }
}
