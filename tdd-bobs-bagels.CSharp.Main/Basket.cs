using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_bobs_bagels.CSharp.Main
{
    public class Basket
    {
        //private Basket _basket;
        private List<string> _ordersInBasket = new List<string>();
       // private List<Basket> __basket = new List<Basket>();

        public Basket()
        {
            _ordersInBasket = new List<string>();
        }
        public bool AddBagelToBasket(string bagel)
        {
            // if _ordersInBasket doesn't have new add bagel in list, add it to list
            if (!_ordersInBasket.Contains(bagel))
            {
                // add bagel to list
                _ordersInBasket.Add(bagel);
                // display wich bagel is added
                Console.WriteLine($"Your {bagel} is added to your order.");
                return true;
            }
            // if false show which bagel is not added to list
            Console.WriteLine($"{bagel} is not added to order!");
            return false;
        }

        // code for change order and remove bagel from order / basket
        public bool ChangeOrder(string bagelToRemove)
        {
            return true;
        }
        
    }
}
