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
       
        public int pricePerPastry {get; set;}
     
        public Pastry()
        {
            pricePerPastry = 2;
            
        }
        // public  int PastryTotal(int pastryNum)
        // {
        //     int totalPastry = 0;



        //     double totalPastry = 0;
        //     return totalPastry;
        // }
    }
}