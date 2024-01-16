using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_bobs_bagels.CSharp.Main
{
    public class Basket
    {
        private List<string> basket = new List<string>();

        private int _basketSize = 10;

        public int basketSize { get { return _basketSize; } set {  _basketSize = value; } }

        public bool addBagel(string type, int amount)
        {
            if ((basket.Count + amount) > basketSize)
            {
                return false;
            }
            else
            {
                for (int i = 0; i < amount; i++)
                {

                    basket.Add(type);
                }
                return true;
            }
        }

        public void removeBagel(string type, int amount)
        { 
            for (int i = 0; i < amount; i++)
            {
                basket.Remove(type);
            }
        }

        public void removeAllBagels()
        {
            basket.Clear();
        }

        public void changeBasketSize(int newSize)
        {
            basketSize = newSize;
        }

        public int checkCurrentBasketCapacity()
        {
            int current = basketSize - basket.Count();
            return current;
        }

        public int checkTotalBasketCapacity()
        {
            return basketSize;
        }

        public bool checkIfBagelIsInBasket(string type)
        {
            if(basket.Contains(type))
            {
                return true;
            }
            else
            {
                return false;
            }
        }




    }

}
