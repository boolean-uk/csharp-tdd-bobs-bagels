using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_bobs_bagels.CSharp.Main
{
    public class Basket
    {
        private int _capacity;
        private List<string> bagels;

        public Basket(int capacity)
        {
            this._capacity = capacity;
            bagels = new List<string>();
        }

        private bool checkCapacity()
        {
            return bagels.Count < _capacity;
        }

        public bool Add(string name)
        {
            if (checkCapacity())
            {
                bagels.Add(name);
                return true;
            }
            return false;
        }

        public bool changeCapacity(int new_capasity)
        {
            if(_capacity != new_capasity)
            {
                _capacity = new_capasity;
                return true;
            }
            return false;
        }

        public bool Remove(string name)
        {
            if (bagels.Contains(name))
            {
                bagels.Remove(name);
                return true;
            }
            return false;
        }
    }
}
