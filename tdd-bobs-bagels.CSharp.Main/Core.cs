using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_bobs_bagels.CSharp.Main
{
    public class Core
    {
        private List<string> _bagels;
        int _nrBagels;
        int _capacity;

        public Core()
        {
            _bagels = new List<string>();
            _nrBagels = 0;
            _capacity = 5;
        }

        public List<string> Bagels { get { return _bagels; } }

        public void Add(string bagel)
        {
            if (_nrBagels != _capacity)
            {
                Bagels.Add(bagel);
                _nrBagels++;
            }
            else
            {
                throw new Exception("Basket is full");
            }
        }

        public void Remove(string bagel)
        {
            if (!Bagels.Remove(bagel))
            {
                throw new Exception("Bagel is not in basket");
            }
        }

        public void DoubleCapacity()
        {
            _capacity *= 2;
        }
    }
}
