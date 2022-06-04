using System;

namespace _19._02_20._02
{
    class Program
    {
        static void Main()
        {
            //Input
            string day = Console.ReadLine();
            int pricePerTicket = 0;
            //Actions
            if (day == "Monday" || day == "Tuesday" || day == "Friday")
                Console.WriteLine(pricePerTicket + 12);
            else if (day == "Wednesday" || day == "Thursday")
                Console.Write(pricePerTicket + 14);
            else
                Console.WriteLine(pricePerTicket + 16);
            //Output




        }
    }
}
