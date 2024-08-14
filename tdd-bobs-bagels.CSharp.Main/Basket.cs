using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_bobs_bagels.CSharp.Main
{
    public class Basket
    {
        public List<string> Items = new List<string>();
        public int BasketMax { get; set; } = 3;
        public bool IsBasketFull { get { return Items.Count >= BasketMax ? true : false; } }

        public bool AddBagel(string bagel)
        {
            if (!IsBasketFull)
            {
                Items.Add(bagel);
                return true;
            }
            return false;
        }
              
        public bool RemoveBagel(string bagel)
        {
            Items.Remove(bagel);
            return true; 
        }

        public int ChangeCapacity(int capacity)
        {
            BasketMax = capacity;
            return BasketMax;
        }

    }
}


