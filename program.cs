using System;
using System.Collections;
using Bakery;

namespace Bakery
{
    public class Progam
    {
        public static void Main()
        {
            Console.WriteLine("Welcome Our Bakery!  Today we have bread and pastries!");
            Console.WriteLine("Can i get a name for the order?");
            string orderName = Console.ReadLine();
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
            Console.WriteLine("Would you like to make another order?");
        }
    }
}