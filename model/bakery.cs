namespace Bakery
{
    public class Bread
    {
        public int price {get; set;}
        public int totalBread {get; set;}

        public Bread()
        {
            price = 5;
            totalBread;
        }
        public static int BreadTotal(int breadNum)
        {
            int breadRemainder = breadNum % 3;
            if(breadRemainder = 0)
            {
                Bread.totalBread = (breadNum * Bread.price) - (Bread.price * (breadNum / 3));
                
            }
            else
            {
                
            }
            Bread.
        }
    }
    public class Pastry
    {
        public int price {get; set;}
        public int totalPastry {get; set;}

        public Pastry()
        {
            price = 2;
            totalPastry;
        }
    }
}