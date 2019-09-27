namespace Bakery
{
    public class Bread
    {
        public int price {get; set;}
        public int totalBread {get; set;}

        public Bread()
        {
            price = 5;
            totalBread = 0;
        }
        
        // public static int BreadRule(int breadNum)
        // {

        // }
        public  int BreadTotal(int breadNum)
        {
            
            

            int breadRemainder = breadNum % 3;
            if(breadRemainder = 0)
            {
                Bread.totalBread = (breadNum * Bread.price) - (Bread.price * (breadNum / 3));
                
            }
            else
            {

            }
            totalBread = breadNum * price;
        }
    }
    public class Pastry
    {
        public int price {get; set;}
        public int totalPastry {get; set;}

        public Pastry()
        {
            price = 2;
            totalPastry = 0;
        }
        public  int PastryTotal(int pastryNum)
        {
            



            totalPastry = ciel(pastryNum / 2 * 2);
        }
    }
}