using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_bobs_bagels.CSharp.Main
{
    public class Basket
    {
        public List<string> bagels = new List<string>();
        public int BasketCapacity { get; set; } = 3;

        public bool AddBagel(string bagel)
        {
            if (bagels.Count() < BasketCapacity)
            {
                bagels.Add(bagel);
                return true;
            }
            return false;
        }

        public bool RemoveBagel(string bagel)
        {
            return bagels.Remove(bagel);
        }

        


    }
}
