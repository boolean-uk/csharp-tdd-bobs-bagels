using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_bobs_bagels.CSharp.Main
{
    public class Basket
    {
        
        public bool AddBagel(string bagel)
        {
            if (this.bagels.Count < this.BasketCapacity)
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

        public void ChangeCapacity(int newCapacity)
        {
            this.BasketCapacity = newCapacity;
        }

        public List<string> bagels = new List<string>();
        public int BasketCapacity { get; set; } = 3;

        public bool IsBasketFull
        {
            get
            {
                return this.BasketCapacity == this.bagels.Count ? true : false;
            }
        }

    }
}
