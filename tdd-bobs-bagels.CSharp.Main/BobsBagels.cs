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

        public void RemoveProduct(string item)
        {
            basket.Remove(item);
        }
    }
}
