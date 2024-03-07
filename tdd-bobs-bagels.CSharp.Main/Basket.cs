using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace tdd_bobs_bagels.CSharp.Main
{
    public class Basket
    {
        //private Basket _basket;
        private List<string> _ordersInBasket = new List<string>();
        private int _basketCapacity;

        public int BasketCapacity
        {
            get { return _basketCapacity; }
            set { _basketCapacity = value; }
        }
        public Basket(int basketCapacity)
        {
            _ordersInBasket = new List<string>();
            _basketCapacity = basketCapacity;
        }
        public bool AddBagelToBasket(string bagel)
        {
            // if _ordersInBasket doesn't have new add bagel in list, add it to list
            if (!_ordersInBasket.Contains(bagel))
            {
                // add bagel to list
                _ordersInBasket.Add(bagel);
                // display wich bagel is added
                Console.WriteLine($"- {bagel} is added to your order.");
                return true;
            }
            // if false show which bagel is not added to list
            Console.WriteLine($"{bagel} is not added to order!");
            return false;
        }

        // code for change order and remove bagel from order / basket
        // if false bagel cant be removed from basket, does not exist.
        public bool ChangeOrder(string bagelToRemove)
        {
            if (_ordersInBasket.Contains("Spelt Bagel"))
            {
                _ordersInBasket.Remove(bagelToRemove);
                Console.WriteLine($"{bagelToRemove} is removed from your order.");

                // prints a list of remaining bagels in your order / basket
                Console.WriteLine("These are your remaining bagel(s) in your order:");
                foreach (var bagel in _ordersInBasket)
                {
                    Console.WriteLine(bagel);
                }

                return true;
            } else
            {
                Console.WriteLine("This bagel is not in your order, it cant be removed");
            }
            return false;
        }   

        public bool FullBasket(int maximumBagels)
        {
            // count amount of bagels in _ordersInBasket, if egual or higher than maximumBagels
            if (_ordersInBasket.Count >= maximumBagels)
            {
                // message that your basket is full
                Console.WriteLine("Your basket is full, not possible to add more bagels to your order.");
                return true;
            }
            Console.WriteLine("You can add more bagels to your order!");
            return false;
        }

        public bool SetBasketCapacity(int newCapacity)
        {
           
            return false;
        }
    }
}
