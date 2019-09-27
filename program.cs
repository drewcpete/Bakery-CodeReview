using System;
using System.Collections;
using Bakery;

namespace Bakery
{
    public class Progam
    {
        public static void Main()
        {
            Console.WriteLine("Welcome to our bakery! Today we are offering bread and pastries.");
            Console.WriteLine("What's your name?");
            string orderName = Console.ReadLine();
            Order(orderName);
        }
        public static void Order(string orderName)
        {

            Console.WriteLine($"Okay, {orderName}, how many loaves of bread would you like?  They're $5 a loaf, but if you buy two, you get one for free!");
            int orderBread = int.Parse(Console.ReadLine());
            Console.WriteLine("How many pastries would you like?  They're $2 a each, or $5 for 3!");
            int orderPastry = int.Parse(Console.ReadLine());

            Bread bread = new Bread(orderBread);
            Pastry pastry = new Pastry(orderPastry);

            bread.FindBreadPrice();
            pastry.FindPastryPrice();

            int orderTotal = bread.BreadOrderPrice + pastry.PastryOrderPrice;
            
            Console.WriteLine($"Your total is ${orderTotal}. ${bread.BreadOrderPrice} for {orderBread} loaves of bread and ${pastry.PastryOrderPrice} for {orderPastry} pastries.");
            Console.WriteLine($"Please send {orderTotal} to $rewpet on the cashapp.");
            Console.WriteLine("Would you like to make another order? y/n");
            string answer = Console.ReadLine();
            if (answer == "y" ||answer == "Y")
            {
                Order(orderName);
            }
            else
            {
                Console.WriteLine("Thanks for your business!");
            }
        }
    }
}