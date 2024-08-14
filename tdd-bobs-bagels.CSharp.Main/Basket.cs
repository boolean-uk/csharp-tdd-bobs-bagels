using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_bobs_bagels.CSharp.Main
{
    public class Basket
    {

        private List<string> _basket = new List<string>();

        public bool basketIsFull = false;
        public int maxBasketSize { get; set; } = 3;

        public bool addBagel(string bagel)
        {
            if (_basket.Count() >= maxBasketSize)
            {
                return basketIsFull;
            }

            _basket.Add(bagel);
            return !basketIsFull;
        }

        public string removeBagel(string bagel1)
        {
            if (!_basket.Contains(bagel1))
            {
                return $"There is no {bagel1} in the basket";
            }

            _basket.Remove(bagel1);
            return $"{bagel1} removed";
            
        }

        public void changeBasketCapacity(int capacity)
        {
            maxBasketSize = capacity;
        }
    }
}
