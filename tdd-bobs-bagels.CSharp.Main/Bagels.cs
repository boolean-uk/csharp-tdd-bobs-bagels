using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace tdd_bobs_bagels.CSharp.Main
{
    public class Bagels
    {
        public void AddBagel(string bagel)
        {
            if (this.BagelBasket.Count < this.BagelBasketMax) 
            {
                this.BagelBasket.Add(bagel);
            }
            
        }

        public bool RemoveBagel(string bagel)
        {
            return this.BagelBasket.Remove(bagel);
        }

        public void SetBagelBasketMax(int value)
        {
            BagelBasketMax = value;
        }

        public List<string> BagelBasket { get; set; } = new List<string>();
        public int BagelBasketMax { get; set; } = 3;
        public bool BagelBasketFull
        { get { return this.BagelBasketMax >= this.BagelBasket.Count ? true : false; } }
    }
}
