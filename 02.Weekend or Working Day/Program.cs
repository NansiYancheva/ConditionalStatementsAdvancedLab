using System;

namespace _19._02_20._02
{
    class Program
    {
        static void Main()
        {
            //Input
            string dayFromTheWeek = Console.ReadLine();
            //Actions
            switch (dayFromTheWeek)
            {
                case "Monday":
                case "Tuesday":
                case "Wednesday":
                case "Thursday":
                case "Friday":
                    Console.WriteLine("Working day");
                    break;
                case "Saturday":
                case "Sunday":
                    Console.WriteLine("Weekend");
                    break;
                default:
                    Console.WriteLine("Error");
                    break;

            }
            //Output




        }
    }
}
