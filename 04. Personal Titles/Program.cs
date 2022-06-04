using System;

namespace _19._02_20._02
{
    class Program
    {
        static void Main()
        {
            //Input
            double age = double.Parse(Console.ReadLine());
            string gender = Console.ReadLine();
            //Actions
            if (gender == "f")
            {
                if (age < 16)
                {
                    Console.WriteLine("Miss");
                }
                else // age > 16
                {
                    Console.WriteLine("Ms.");

                }
            }
            else if (gender == "m")// gender == m
            {
                if (age < 16)
                {
                    Console.WriteLine("Master");
                }
                else // age > 16
                {
                    Console.WriteLine("Mr.");

                }
            }
            //Output




        }
    }
}
