using System;


namespace Bakery
{
    public class Bread
    {
        public int pricePerBread {get; set;}
      
        public Bread(int breadNum)
        {
            pricePerBread = 5;
            
        }
        
        // public static int BreadRule(int breadNum)
        // {

        // }
        public int BreadTotal(int breadNum)
        {                
            int totalBread = (breadNum / 2 * pricePerBread);
            return totalBread;
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