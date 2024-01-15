using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_bobs_bagels.CSharp.Main
{
    public class Core
    {
        public List<string> Basket { get; set; }
        public int cap = 5;
        public int current = 0;
        public Core() 
        {
            Basket = new List<string>();
        }
        public bool addBagel(string bagel)
        {
            bool result = false;

            if(cap > current)
            {
                Basket.Add(bagel);
                current += 1;
                result = true;
            }

            return result;

        }
        public bool removeBagel(string bagel)
        {
            bool result = false;

            if (Basket.Contains(bagel))
            {
                Basket.Remove(bagel);
                current -= 1;
                result = true;
            }

            return result;
        }
        public bool maxCap(int newCap)
        {
            bool result = false;

            if(newCap > 0 && newCap > Basket.Count)
            {
                cap = newCap;
                result = true;
            }

            return result;

        }

    }
}
