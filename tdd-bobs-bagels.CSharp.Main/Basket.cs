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

        /// <summary>
        /// Attempt to add a bagel type to the basket.
        /// </summary>
        /// <param name="bagelType"> string - the name of the bageltype to be added </param>
        /// <returns> bool - True if the bagel was added, otherwise false </returns>
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

        /// <summary>
        /// Attempt to remove a specific bagel from the basket. 
        /// </summary>
        /// <param name="bagelType">string - The name of the bagel to be removed</param>
        /// <returns>bool - True if the bagel was successfully removed from the basket, false if the bagel could not be removed. </returns>
        public bool RemoveBagelFromBasket(string bagelType) 
        {
            return _basket.Remove(bagelType);
        }

        /// <summary>
        /// Method that determines if the basket object has room for additional items.
        /// </summary>
        /// <returns>bool - True if the basket has room for additional items, false if there is no more room.</returns>
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
        /// <param name="newSize"> int - The new size of the basket. </param>
        /// <returns>The number of items remaining in the basket. For basket increases this value will not change, but it will change for size reduction</returns>
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
