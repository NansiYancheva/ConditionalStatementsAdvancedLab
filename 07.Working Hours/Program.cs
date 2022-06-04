using System;

namespace _19._02_20._02
{
    class Program
    {
        static void Main()
        {
            //Input
            int hour = int.Parse(Console.ReadLine());
            string day = Console.ReadLine();
            //if (hour >= 10 || hour <= 18 || day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday" || day == "Saturday")
            if (hour >= 10 && hour <= 18 && day != "Sunday")
            {
                Console.WriteLine("open");
            }
            else
            {
                Console.WriteLine("closed");
            }





        }
    }
}

