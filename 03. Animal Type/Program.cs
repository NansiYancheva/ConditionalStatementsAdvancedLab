using System;

namespace _19._02_20._02
{
    class Program
    {
        static void Main()
        {
            //Input
            string nameOfAnimal = Console.ReadLine();
            //Actions
            if (nameOfAnimal == "dog")
                Console.WriteLine("mammal");
            else if (nameOfAnimal == "crocodile" || nameOfAnimal == "tortoise" || nameOfAnimal == "snake")
                Console.WriteLine("reptile");
            else
                Console.WriteLine("unknown");
            //Output




        }
    }
}
