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
            _maxBasketSize = 4;
        }

        public bool AddBagelToBasket(string bagelType) 
        {
            throw new NotImplementedException();
        }

        public bool RemoveBagelFromBasket(string bagelType) 
        {
            throw new NotImplementedException();
        }

        public bool BasketHasRoom()
        {
            throw new NotImplementedException();
        }

        public int SetBasketSize(int newSize) 
        {
            throw new NotImplementedException();
        }
    }
}
