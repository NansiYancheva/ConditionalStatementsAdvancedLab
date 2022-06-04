using System;

namespace _19._02_20._02
{
    class Program
    {
        static void Main()
        {
            //Input
            string nameOfProduct = Console.ReadLine();
            string nameOfTown = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            double priceOfProduct = 0;
            //Actions
            //beggining Sofia
            if (nameOfTown == "Sofia")
            {
                if (nameOfProduct == "coffee")
                {
                    priceOfProduct = quantity * 0.50;
                }
                else if (nameOfProduct == "water")
                {
                    priceOfProduct = quantity * 0.80;
                }
                else if (nameOfProduct == "beer")
                {
                    priceOfProduct = quantity * 1.20;
                }
                else if (nameOfProduct == "sweets")
                {
                    priceOfProduct = quantity * 1.45;
                }
                else if (nameOfProduct == "peanuts")
                {
                    priceOfProduct = quantity * 1.60;
                }
            }
            //end Sofia
            //beginning Plovdid
            else if (nameOfTown == "Plovdiv")
            {
                if (nameOfProduct == "coffee")
                {
                    priceOfProduct = quantity * 0.40;
                }
                else if (nameOfProduct == "water")
                {
                    priceOfProduct = quantity * 0.70;
                }
                else if (nameOfProduct == "beer")
                {
                    priceOfProduct = quantity * 1.15;
                }
                else if (nameOfProduct == "sweets")
                {
                    priceOfProduct = quantity * 1.30;
                }
                else if (nameOfProduct == "peanuts")
                {
                    priceOfProduct = quantity * 1.50;
                }
            }
            //end Plovdiv
            //beggining Varna
            else if (nameOfTown == "Varna")
            {
                if (nameOfProduct == "coffee")
                {
                    priceOfProduct = quantity * 0.45;
                }
                else if (nameOfProduct == "water")
                {
                    priceOfProduct = quantity * 0.70;
                }
                else if (nameOfProduct == "beer")
                {
                    priceOfProduct = quantity * 1.10;
                }
                else if (nameOfProduct == "sweets")
                {
                    priceOfProduct = quantity * 1.35;
                }
                else if (nameOfProduct == "peanuts")
                {
                    priceOfProduct = quantity * 1.55;
                }
            }
            //end Varna
            //Output
            Console.WriteLine(priceOfProduct);



        }
    }
}
