using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_bobs_bagels.CSharp.Main
{
    public class Basket
    {
        private List<string> Bagels;
        private int BasketCapacity;

        public Basket(int initialCapacity)
        {
            Bagels = new List<string>();
            BasketCapacity = initialCapacity;
        }

        public bool AddBagel(string bagel)
        {
            if (IsBasketFull())
            {
                return false;
            }

            Bagels.Add(bagel);
            return true;
        }

        public bool RemoveBagel(string bagel)
        {
            if (Bagels.Contains(bagel))
            {
                Bagels.Remove(bagel);
                return true;
            }

            return false;
        }

        public bool IsBasketFull()
        {
            return Bagels.Count >= BasketCapacity;
        }

        public void SetBasketCapacity(int newCapacity)
        {
            BasketCapacity = newCapacity;
        }
    }
}
