using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_bobs_bagels.CSharp.Main
{
    public class Basket
    {
        public List<string> basket;
        public int capacity;

        public Basket()
        {
            basket = new List<string>();
            capacity = 3;
        }

        public bool AddBagel(string bagelType)
        {
            return false;
        }

        public bool RemoveBagel(string bagelType)
        {
            return false;
        }

        public bool BasketFull()
        {
            return false;
        }

        public int IncreaseCapacity()
        {
            return 0;
        }

        public bool ItemEsists(string bagelType)
        {
            return false;
        }
    }
}