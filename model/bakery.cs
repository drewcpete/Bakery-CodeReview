using System;

namespace Bakery
{
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
        public void FindBreadPrice()
        {
            int freeBread = BreadOrder/2;
            BreadOrderPrice = (BreadOrder - freeBread)*BreadPrice;
        }
    }
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
        public void FindPastryPrice()
        {            
            PastryOrderPrice = ((PastryOrder % 3)*2) + (PastryOrder / 3 * 5);
        }
    }
}