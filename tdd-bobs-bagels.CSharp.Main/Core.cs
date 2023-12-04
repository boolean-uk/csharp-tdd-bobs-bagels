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

        public int MaxCapacity { get; set; } = 3;

        public string AddBagel(string bagel)
        {
            if (Basket.Count < MaxCapacity)
            {
                Basket.Add(bagel);
                return "Bagel added";
            } else
            {
                return "Basket is full";
            }
            
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
