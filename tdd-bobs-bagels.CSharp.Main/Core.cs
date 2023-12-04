using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_bobs_bagels.CSharp.Main
{
    public class Core
    {
        public List<string> Basket = new List<string>();

        public void AddBagel(string bagel)
        {
            Basket.Add(bagel);
        }

        public void RemoveBagel(string bagel)
        {
            if (Basket.Contains(bagel))
            {
                Basket.Remove(bagel);
            }
        }
    }
}
