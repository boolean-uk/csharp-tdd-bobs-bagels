using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_bobs_bagels.CSharp.Main
{
    public class Bagels
    {
        public void AddBagel(string bagel)
        {
            this.BagelBasket.Add(bagel);
        }

        public bool RemoveBagel(string bagel)
        {
            return this.BagelBasket.Remove(bagel);
        }

        public List<string> BagelBasket { get; set; } = new List<string>();
    }
}
