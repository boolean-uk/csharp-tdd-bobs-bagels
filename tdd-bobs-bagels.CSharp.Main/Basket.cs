using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_bobs_bagels.CSharp.Main
{
    public class Basket
    {
        List<string> _basket;
        int _maxBasketSize;

        public Basket() 
        {
            _basket = new List<string>();
            _maxBasketSize = 5;
        }

        public bool AddBagelToBasket(string bagelType) 
        {
            if (!HasRoom()) 
            {
                return false;
            }

            int numBefore = _basket.Count;
            _basket.Add(bagelType);
            int numAfter = _basket.Count;

            if (numBefore < numAfter)
            {
                return true;
            } else 
            {
                return false;
            }
        }

        public bool RemoveBagelFromBasket(string bagelType) 
        {
            return _basket.Remove(bagelType);
        }

        public bool HasRoom()
        {
            if ((_basket.Count) < _maxBasketSize)
            {
                return true;
            }
            else 
            {
                Console.WriteLine("You can't get more bagels because the basket is full!");
                return false;
            }
        }

        /// <summary>
        /// Changes the maximum size of the basket. If size is set below current capacity any overflow is deleted.
        /// </summary>
        /// <param name="newSize"></param>
        /// <returns>The number of items remaining in the basket. For basket increases this value will not change, but it will change for size reduction</returns>
        /// <exception cref="NotImplementedException"></exception>
        public int SetBasketSize(int newSize) 
        {
            _maxBasketSize = newSize;
            while (_basket.Count > _maxBasketSize) // Prune basket until it complies with the new size rules.
            {
                _basket.RemoveAt(new Random().Next(0, _basket.Count));
            } 

            return _basket.Count;
        }
    }
}
