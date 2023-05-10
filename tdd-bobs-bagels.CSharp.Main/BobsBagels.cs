using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_bobs_bagels.CSharp.Main
{
    public class BobsBagels
    {
        public List <string> basket = new List <string> ();
        public int MaxCapacityBasket = 3;
        public void AddProduct(string item)
        {
            if(this.basket.Count < this.MaxCapacityBasket) 
            { 
            basket.Add(item);
            }
        }

        public string ChangeBasketCapacity(int count)
        {
            // if basket.count < count
            if(basket.Count < count) 
            { 
                MaxCapacityBasket = count;
                return $"The new basketsize is {count}";
            }
            else
            {
                return $"There are more items in the basket than {count}";
            }
            //else basket.count > count either remove items from existing basket or give back message
        }

        public string RemoveProduct(string item)
        {
            if (basket.Contains(item)) 
            {
                basket.Remove(item);
                return $"{item} removed";
            } 
            else
            {
                return "Item not found";
            }

        }
    }
}
