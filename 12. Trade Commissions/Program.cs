using System;

namespace _19._02_20._02
{
    class Program
    {
        static void Main()
        {
            //Input
            string town = Console.ReadLine();
            double sales = double.Parse(Console.ReadLine());
            double commision = 0;
            //Actions
            //Beginning Sofia
            if (town == "Sofia")
            {
                if (sales >= 0 && sales <= 500)
                {
                    commision = sales * 5 / 100;
                }
                else if (sales > 500 && sales <= 1000)
                {
                    commision = sales * 7 / 100;
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    commision = sales * 8 / 100;
                }
                else if (sales > 10000)
                {
                    commision = sales * 12 / 100;
                }
                //if sales < 0
                if (sales < 0)
                    Console.WriteLine("error");
            }
            //end Sofia
            //Begining Varna
            else if (town == "Varna")
            {
                if (sales >= 0 && sales <= 500)
                {
                    commision = sales * 4.5 / 100;
                }
                else if (sales > 500 && sales <= 1000)
                {
                    commision = sales * 7.5 / 100;
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    commision = sales * 10 / 100;
                }
                else if (sales > 10000)
                {
                    commision = sales * 13 / 100;
                }
                //if sales < 0
                if (sales < 0)
                    Console.WriteLine("error");
            }
            //end Varna
            //Beginning Plovdiv
            else if (town == "Plovdiv")
            {
                if (sales >= 0 && sales <= 500)
                {
                    commision = sales * 5.5 / 100;
                }
                else if (sales > 500 && sales <= 1000)
                {
                    commision = sales * 8 / 100;
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    commision = sales * 12 / 100;
                }
                else if (sales > 10000)
                {
                    commision = sales * 14.5 / 100;
                }
                //if sales < 0
                if (sales < 0)
                    Console.WriteLine("error");
            }
            //end Plovdiv
            //error if else
            else
                Console.WriteLine("error");



            //Output
            if (commision > 0)
                Console.WriteLine($"{commision:f2}");



        }
    }
}

