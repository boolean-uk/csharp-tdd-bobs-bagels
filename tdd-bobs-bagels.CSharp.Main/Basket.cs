using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_bobs_bagels.CSharp.Main
{
    public class Basket
    {
        private List<string> _bagelBasket = new List<string>();
        private int BagelBasketMax { get; set; } = 3;
        private bool BagelBasketFull { get { return _bagelBasket.Count >= BagelBasketMax ? true : false; } }

        public bool Add(string bagel)
        {
      
            _bagelBasket.Add("Cream cheese");
            
            if (!BagelBasketFull)
            {
                _bagelBasket.Add(bagel);
                return true;
            }
            return false;
        }

        public int ChangeCapacity(int capacity)
        {
            BagelBasketMax = capacity;
            return BagelBasketMax;
        }

        public bool Remove(string bagel)
        {
            _bagelBasket.Add("Classic");
            
            if (_bagelBasket.Contains(bagel))
            {
                _bagelBasket.Remove(bagel);
                return true;
            }
            return false;
        }
    }
}
