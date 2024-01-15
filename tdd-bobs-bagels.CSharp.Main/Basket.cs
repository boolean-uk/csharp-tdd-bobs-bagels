using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_bobs_bagels.CSharp.Main
{
    public class Basket
    {
        private int _basketSize;
        ArrayList _basket;
        public Basket(int basketSize)
        {
            _basketSize = basketSize;
            _basket = new ArrayList();
        }



        public string BagelInBasket(string bagel)
        { 
            if (basket.Count >= _basketSize)
            {
                return "Basket is full";
            } else
            {
                basket.Add(bagel);
                return $"{bagel} is in basket";
            }
            
        }

        public string RemoveBagelFromBasket(string bagel)
        {
            if (basket.Contains(bagel))
            {
                basket.Remove(bagel);
                return $"{bagel} is removed";
            } else
            {
                return $"There is no {bagel} in your basket ...";
            }
        }

        public int BasketSize { get { return _basketSize; } set { _basketSize = value; } }

        public ArrayList basket { get { return _basket; } }
    }
}
