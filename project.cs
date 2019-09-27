using System;
using System.Collections;
using Bakery;

namespace Bakery
{
    public class Progam
    {
        public static void Main()
        {
            Console.WriteLine("Welcome to &rew's Bake Shop!  Today we have bread and pastries!");
            Console.WriteLine("Can i get a name for the order?");
            string orderName = Console.ReadLine();
            Console.WriteLine($"Okay, {orderName}, how many loaves of bread would you like?  They're $5 a loaf, but if you buy two, you get one for free!");
            int orderBread = Console.ReadLine();
            Console.WriteLine("How many pastries would you like?  They're $2 a each, or $5 for 3!");
            int orderPastry = Console.ReadLine();
            Bread.BreadTotal(orderBread);
            

        }


    }

}