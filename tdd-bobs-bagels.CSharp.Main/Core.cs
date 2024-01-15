using NUnit.Framework.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_bobs_bagels.CSharp.Main
{
    public class Core
    {
        private List<string> bagels = new List<string>();
        private int capacity;

        public Core(int capacity)
        {
            this.capacity = capacity;
        }

        public int SetCapacity()
        {
            return capacity;
        }

        public bool IsFull()
        {
            return bagels.Count >= capacity;
        }

        public bool AddBagel(string bagel)
        {
            if (bagels.Count < capacity)
            {
               bagels.Add(bagel);
               return true;
            }
            return false;
        }

        public bool RemoveBagel(string bagel)
        {
            if (bagels.Contains(bagel))
            {
                bagels.Remove(bagel);
                return true;
            }
            else
            {
                return false;
            }
        }

        public int GetBagelCount()
        {
            return bagels.Count;
        }

        public void ChangeBasketCapacity(int newCapacity)
        {
            capacity = newCapacity;
        }
    }
}