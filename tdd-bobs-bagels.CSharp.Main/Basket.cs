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
            if (BasketFull())
                return false;

            if (ItemEsists(bagelType))
                return false;

            if (bagelType == "")
                return false;

            basket.Add(bagelType);
            return true;
        }

        public bool RemoveBagel(string bagelType)
        {
            if (!ItemEsists(bagelType))
                return false;

            for (int i = 0; i < basket.Count(); i++)
            {
                if (basket[i] == bagelType)
                    basket.RemoveAt(i);
            }

            return true;
        }

        public bool BasketFull()
        {
            if (basket.Count() == capacity)
                return true;

            return false;
        }

        public int IncreaseCapacity(int newCapacity)
        {
            if (newCapacity > capacity)
                capacity = newCapacity;

            return capacity;
        }

        public bool ItemEsists(string bagelType)
        {
            for (int i = 0; i < basket.Count(); i++)
            {
                if (basket[i] == bagelType)
                    return true;
            }

            return false;
        }
    }
}