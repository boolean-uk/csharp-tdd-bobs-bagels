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

        public void Order(string bagel)
        {
            Orders.Add(bagel);
        }

        public bool Remove(string bagel)
        {
            return Orders.Remove(bagel);
        }
    }
}
