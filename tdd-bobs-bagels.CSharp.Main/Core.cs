using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_bobs_bagels.CSharp.Main
{
    public class Core
    {

        public List<string> _basket;
        private List<string> basket
        {
            get { return _basket; }
            set { _basket = value; }
        }

        public int _capacity;
        private int capacity
        {
            get { return _capacity; }
            set { _capacity = value; }
        }

        public Core()
        {
            basket = new List<string>();
            basket.Add("cheese");
            basket.Add("plane");
            basket.Add("choco");
            capacity = 5;
        }

        public bool checkCapacity()
        {
            if (basket.Count < capacity)
            {
                return true;
            }
            return false;
        }

        public bool checkItem(string item)
        {
            if (basket.Contains(item))
            {
                return true;
            }
            return false;
        }

        public bool addItem(string item)
        {
            if (checkCapacity())
            {
                basket.Add(item);
                return true;
            }
            return false;
        }

        public bool removeItem(string item)
        {
            if (checkItem(item))
            {
                basket.Remove(item);
                return true;
            }
            return false;
        }

        public bool changeCapacity(int capacity, string identity)
        {
            if (identity.Equals("manager"))
            {
                this.capacity = capacity;
                return true;
            }
            return false;
        }
    }
}
