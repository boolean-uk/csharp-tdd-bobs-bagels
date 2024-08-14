using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_bobs_bagels.CSharp.Main
{
    public class Basket
    {
        private List<string> _bagels = new List<string>();
 
        public bool basketIsFull = false;
        public int basketMaxSize { get; set; } = 3;

        public bool addBagel(string bagel)
        {
            if (basketMaxSize <= _bagels.Count())
            {
                return false;
            }
            _bagels.Add(bagel);

            return true;
        }

        public string removeBagel(string bagel)
        {
            if (!_bagels.Contains(bagel))
            {
                return "bagel does not exist";
            }
            _bagels.Remove(bagel);
            return "bagel removed";
        }

        public void changeCapacity(int v)
        {
            if (v <= 0) 
            {
                return;
            }

            basketMaxSize = v;
        }
    }
}
