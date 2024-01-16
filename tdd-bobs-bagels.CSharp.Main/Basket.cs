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
        public int BasketCapacity { get; set; } = 10;

        public Dictionary<string, int> Items = new Dictionary<string, int>();
       

        public bool AddBagel(string bagelType, int price)
        {
            // Check if the basket is full 
            if (Items.Count >= BasketCapacity)
            {
                return false; // Basket is full
            } else

            Items.Add(bagelType, price);
            // Bagel added successfully
            return true; 
        }


        public bool RemoveBagel(string bagelType)
        {
            //check if the basket is empty
            if (Items.Count == 0)
            {
                return false; // Basket is empty
            }
            // Find and remove the specified bagel type
            bool removed = Items.Remove(bagelType);

            // Return true if the bagel is found and removed; otherwise, false
            return removed;
        }

        public bool IsBasketFull(Dictionary<string,int> items)
        {
            if (Items.Count > BasketCapacity)
            {
                return false;

            } else 
            return true;
        }

        public bool ChangeBasketCapacity(int newCapacity)
        {
            if (newCapacity <= 0 || newCapacity == BasketCapacity)
            {
                return false; // Invalid or same capacity
            }

            BasketCapacity = newCapacity;

            //  If capacity changed successfully
            return true; 
        }

        public bool RemoveItemThatDoesntExist (string bagelType)
        {
            if (!Items.ContainsKey(bagelType))
                return false;
            else
            {
                return true;
            }
        }


    }
}
