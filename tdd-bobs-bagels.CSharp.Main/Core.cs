using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_bobs_bagels.CSharp.Main
{
    public class Core
    {
        public List<string> items = new List<string>();
        public int capacity = 5; 

        public bool AddBagel(string bagelType)
        {
            return false; 
        }

        public bool RemoveBagel(string bagelType)
        {
            return false;
        }

        public bool IsFull()
        {
            return false;
        }

        public void SetCapacity(int newCapacity)
        {
        }
    }
}
