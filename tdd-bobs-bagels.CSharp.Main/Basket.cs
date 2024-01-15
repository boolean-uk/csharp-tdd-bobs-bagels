using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_bobs_bagels.CSharp.Main
{
    public class Basket
    {
        public List<string> Orders { get; set; } = new();
        private int _capacity = 5;

        public int Capacity { get { return _capacity;} set { _capacity = value; } }

        public void Order(string bagel)
        {
            if (Orders.Count >= Capacity)
            {
                throw new Exception("The basket is overflowing!");
            }
            Orders.Add(bagel);
        }

        public bool Remove(string bagel)
        {
            bool isRemoved = Orders.Remove(bagel)
                ? true : throw new Exception("That bagel does not exist!");
            return isRemoved;
        }
    }
}
