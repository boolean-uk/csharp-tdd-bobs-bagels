using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_bobs_bagels.CSharp.Main
{
    public class Basket
    {
        private List<string> items = new List<string>();
        public int MAX_CAPACITY = 5;

        public bool Add(string item)
        {

            if(!items.Contains(item) && items.ToArray().Length < 5)
            {
                items.Add(item);
                return true;
            }

            return false;
        }

        public bool Remove(string item)
        {
            if (items.Contains(item))
            {
                items.Remove(item);
                return true;
            }

            return false;
        }

        public int ChangeCapacity(int capacity)
        {
            MAX_CAPACITY = capacity;

            return MAX_CAPACITY;
        }
    }
}
