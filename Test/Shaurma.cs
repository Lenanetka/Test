using System;

namespace Shaurma
{
    public class Shaurma
    {
        private int cost = 10;
        public Shaurma()
        {

        }
        public Shaurma(int cost)
        {
            setPrice(cost);
        }
        public string call()
        {
            return "Sweet shaurma, come up!!!";
        }
        public void setPrice(int cost)
        {
            if (cost < 0) throw new Exception("You are crazy, cost cannot be less than 0!");
            if (cost < 10 || cost >= 1000) throw new Exception("I'm quitting!");
            this.cost = cost;
        }
        public string price(int number)
        {
            if (number <= 0) return "Are you kidding me?";
            return number * cost + "$";
        }
    }
}
