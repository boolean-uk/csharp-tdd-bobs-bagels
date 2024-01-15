using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_bobs_bagels.CSharp.Main
{
    public class Basket {


        public List<string> _bagels;
        public int maxCapacity;

        public Basket() {
            _bagels = new List<string>();
        }

        public bool AddToBasket(string _bagel) {
            if (!isFull()) {
                _bagels.Add(_bagel); return true;
            }
            else {
                return false;
            }
        }

        private bool isFull()
        {
            return _bagels.Count >= maxCapacity;
        }

        public void ChangeBasketSize(int newSize)
        {
            maxCapacity = newSize;
        }

        public bool RemoveFromBasket(string _bagel)
        {
            if (_bagels.Contains(_bagel))
            {
                _bagels.Remove(_bagel); return true; // Only removes the first occurrence of _bagel
            } else
            {
                return false;  
            }
        }
    }
}
