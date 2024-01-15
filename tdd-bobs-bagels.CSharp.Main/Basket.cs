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
            throw new NotImplementedException();
        }

        public bool RemoveBagelFromBasket(string bagelType) 
        {
            throw new NotImplementedException();
        }

        public bool HasRoom()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Changes the maximum size of the basket. If size is set below current capacity any overflow is deleted.
        /// </summary>
        /// <param name="newSize"></param>
        /// <returns>The number of items remaining in the basket. For basket increases this value will not change, but it will change for size reduction</returns>
        /// <exception cref="NotImplementedException"></exception>
        public int SetBasketSize(int newSize) 
        {
            throw new NotImplementedException();
        }
    }
}
