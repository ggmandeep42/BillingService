using System;
using System.Collections.Generic;

namespace BillingService
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, double> dictMenu = new Dictionary<int, double>();
            dictMenu.Add(1, 0.5);
            dictMenu.Add(2, 1.0);
            dictMenu.Add(3, 2.0);
            dictMenu.Add(4, 4.5);

            Console.WriteLine("Menu Items!");
            Console.WriteLine("Cola-Cold - 50 cents --> 1");
            Console.WriteLine("Coffee-Hot - $1.00 --> 2");
            Console.WriteLine("Cheese Sandwich-Cold - $ 2.00 --> 3");
            Console.WriteLine("Steak Sandwich-Hot - $ 4.50 --> 4");

            double n = 0;
            Console.WriteLine("Enter number of Items you wish to purchase from above Menu");

            try
            {
                n = Convert.ToInt32(Console.ReadLine());

                bool IsSolidFood = false;
                int x = 0;
                double total = 0;

                Console.WriteLine("Enter menu code below to purchase items!");

                for (int i = 0; i < n; i++)
                {
                    x = Convert.ToInt32(Console.ReadLine());
                    if (x == 3 || x == 4)
                    {
                        IsSolidFood = true;
                    }

                    total += dictMenu[x];
                }

                if (IsSolidFood)
                {
                    total += (0.1 * total);
                }

                Console.WriteLine("Total bill: $ " + total.ToString("#.##"));
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception : "+ex.Message);
            }
            
        }
    }
}
