using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace tdd_bobs_bagels.CSharp.Main
{
    public class Basket
    {
        public List<String> myBasket = new List<String>();

        public int BasketSize { get; set; } = 5;

        public bool AddBagel(String bagel)
        {
            myBasket.Add(bagel);
            return true;
        }

        public bool RemoveBagel(String bagel)
        {
            myBasket.Remove(bagel);
            return true;
        }

        public bool FullBasket(List<String> bagels)
        {
            bool isFull = false;
            if (bagels.Count < BasketSize)
            {
                Console.WriteLine("Your basket is not full!");
                isFull = false;
            } else if (bagels.Count >= BasketSize)
            {
                Console.WriteLine("Your basket is full!");
                isFull = true;
            }
            return isFull;
        }
        public int BasketCapacity(int newCap)
        {
           return BasketSize = newCap;
        }

        public bool SchrodingersBagel(String bagel)
        {
            bool hypotheticalBagel = true;
            if (!myBasket.Contains(bagel))
            {
                hypotheticalBagel = false;
                Console.WriteLine($"{bagel} does not exist and can NOT be removed from basket");
            }
            else
            {
                hypotheticalBagel = true;
                Console.WriteLine($"{bagel} exists and can be removed from basket");
            }
            return hypotheticalBagel;
        }
    }
}
