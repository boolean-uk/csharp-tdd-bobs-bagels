using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_bobs_bagels.CSharp.Main
{
    public class Basket
    {
        public List<string> Bagels { get; set; } = new List<string>();

        public void AddBagel(string bagel)
        {
            this.Bagels.Add(bagel);
        }

        public bool RemoveFromBasket(string bagel)
        {
            return this.Bagels.Remove(bagel);
        }
    }

    
}
