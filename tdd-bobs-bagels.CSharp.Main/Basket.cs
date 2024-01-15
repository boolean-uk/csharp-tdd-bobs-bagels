using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

/*
1.
As a member of the public,
I'd like to add a specific type of bagel to my basket,
So I can order a bagel before work.

2.
As a member of the public,
I'd like to remove a bagel from my basket
So I can change my order.

3.
As a member of the public,
I'd like to know when my basket is full when I try adding an item beyond my basket capacity,
So that I can not overfill my small bagel basket.

4.
As a Bob's Bagels manager,
So that I can expand my business,
I’d like to change the capacity of baskets.

5.
As a member of the public
So that I can maintain my sanity
I'd like to know if I try to remove an item that doesn't exist in my basket.
*/


/*
Domain Model

- Class Basket

- Properties
public int capacity = 5 // (capacity of basket)
private Dictionary<int id, string bagel> Items // (dictionary of bageles by id)
public string[] basket = new string[capacity]; // (array of items in basket)

- Methods
public bool ChangeCapacity(int newCapacity) // change capacity of basket
public bool AddItem(int id) // add item to basket, if basket is full, return false
public bool RemoveItem(int id) // remove item from basket, if basket is empty, return false
*/


namespace tdd_bobs_bagels.CSharp.Main
{
    
    public class Basket
    {
        static int capacity = 5;

        private Dictionary<int, string> items = new Dictionary<int, string>()
        {
            {1, "Plain Bagel"},
            {2, "Seeded Bagel"},
            {3, "Cinnamon & Raisin Bagel"},
            {4, "Blueberry Bagel"},
            {5, "Poppy Seed Bagel"}
        };

        public List<string> BagetBasket = new List<string>();

        public bool ChangeCapacity(int newCapacity)
        {
            if (newCapacity > 0)
            {
                capacity = newCapacity;
                return true;
            }
            else
            {
                return false;
            }
        }
        
        public bool AddItem(int id)
        {
            if (BagetBasket.Count < capacity)
            {
                BagetBasket.Add(items[id]);

                return true;
            }
            else
            {
                return false;
            }
        }

        public bool RemoveItem(int id)
        {
            if (BagetBasket.Count > 0)
            {
                BagetBasket.Remove(items[id]);
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}



