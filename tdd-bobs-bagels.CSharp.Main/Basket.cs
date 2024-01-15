using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_bobs_bagels.CSharp.Main
{
    public class Basket
    {
        List<string> items = new List<string>();
        public int basketLimit { get; set; } = 2;
        public Basket() { }

        public string addBagel(string bagel)
        {
            if (bagel == "") { return "no input detected"; }
            if (items.Count >= basketLimit) { return "cart is full"; }

            items.Add(bagel);
            return "added to Basket";
        }
        public string removeBagel(string bagel)
        {
            if(bagel == "") { return "no input detected"; }
            if(!items.Contains(bagel)) { return "bagel doesnt exist in basket"; }
            items.Remove(bagel);
            return "removed from Basket";
        }
        public bool changeLimit(int limit) 
        {  
            if (limit > 0) { 
                basketLimit = limit;
                return true; 
            }
            return false; 
        }
    }
}
