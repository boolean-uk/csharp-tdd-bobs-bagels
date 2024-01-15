using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_bobs_bagels.CSharp.Main
{
    public class Basket
    {
        public List<string> content = new List<string>();
        public int basketLimit = 3;
        public string errorMessage = "Unknown Error";

        public void add(string bagel)
        {
            if(content.Count() < basketLimit)
            {
                content.Add(bagel);
            } else
            {
                errorMessage = "Basket already full";
            }
        }

        public void remove(string bagel)
        {
            content.RemoveAll(x => x == bagel);
        }
        public void changeBasketLimit(int newLimit)
        {
            if(content.Count() < newLimit)
            {
                basketLimit = newLimit;
            } else
            {
                errorMessage = "Limit cannot be lower than current items in basket";
            }
        }
    }
}
