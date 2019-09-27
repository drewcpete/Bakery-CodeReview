using System;

namespace Bakery
{
    //A new class for Bread
    class Bread
    {
        public int BreadOrder {get; set;}
        public int BreadPrice {get; set;}
        public int BreadOrderPrice {get; set;}

        public Bread(int breadOrder)
        {
            BreadOrder = breadOrder;
            BreadPrice = 5;            
        }
        //Method for finding the price of bread with the discount of buying two and getting the thrid free
        public void FindBreadPrice()
        {
            int freeBread = BreadOrder/2;
            BreadOrderPrice = (BreadOrder - freeBread)*BreadPrice;
        }
    }
    //A new class for Pastry
    public class Pastry
    {       
        public int PastryOrder {get; set;}
        public int PastryPrice {get; set;}
        public int PastryOrderPrice {get; set;}     
        public Pastry(int pastryOrder)
        {
            PastryOrder = pastryOrder;
            PastryPrice = 2;            
        }
        //method for finding the pastry cost with the discount of buying 3 for $5
        public void FindPastryPrice()
        {            
            PastryOrderPrice = ((PastryOrder % 3)*2) + (PastryOrder / 3 * 5);
        }
    }
}