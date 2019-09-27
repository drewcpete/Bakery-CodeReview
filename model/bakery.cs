using System;


namespace Bakery
{
    public class Bread
    {
        public double pricePerBread {get; set;}
      
        public Bread(double breadNum)
        {
            pricePerBread = 5;
            
        }
        
        // public static int BreadRule(int breadNum)
        // {

        // }
        public double BreadTotal(double breadNum)
        {                
            double totalBread = Math.Ceiling(breadNum / 2 * pricePerBread);
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