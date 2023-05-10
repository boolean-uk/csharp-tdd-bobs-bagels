using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_bobs_bagels.CSharp.Main
{
    public class Core
    {
        public List<string> basket = new List<string>();
        
        public List<string> addBagel(string bagel)
        {
            if (basket.Contains(bagel))
            {
                Console.WriteLine($"{bagel} is already in basket.");
            } else
            {
                if (basket.Count < basketMax)
                {
                    basket.Add(bagel);
                }
                else
                {
                    Console.WriteLine("Basket is full");
                }
            }
            return basket;
        }

        public bool removeBagel(string bagel)
        {
            if (basket.Contains(bagel))
            {
                basket.Remove(bagel);
                return true;
            }
            else
            {
                Console.WriteLine($"{bagel} is not in basket.");
                return false;
            }
        }

        public int basketMax { get; set; } = 3;
        public bool basketFull { get { return basketMax >= basket.Count ? true : false; } }
        public void changeCapacity(int max)
        {
            basketMax = max;

            basket.RemoveRange(max, basket.Count - max);
        }
    }
}
