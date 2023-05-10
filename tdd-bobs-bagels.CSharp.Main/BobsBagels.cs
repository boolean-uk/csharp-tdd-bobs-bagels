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
        public void AddProduct(string item)
        {
            basket.Add(item);
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
