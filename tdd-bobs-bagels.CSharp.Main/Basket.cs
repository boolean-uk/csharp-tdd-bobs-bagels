using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_bobs_bagels.CSharp.Main
{
    public class Basket
    {

        private List<string> _items = new List<string>();
        private int _capacity ;

        public Basket() { }

        public List<string> Items { get { return _items; } }
        public int Capacity { get { return _capacity; } set { _capacity = value; } }

        public void orderBagel(string bagel)
        {
            if(_capacity > 0)
            {

            _items.Add(bagel);
            _capacity-=1;
            }
        
        }

        public void removeBagel(string bagel)
        {
            if (_items.Contains(bagel))
            {
                _items.Remove(bagel);
                _capacity+=1;
            }
            
        }

        public bool isFull()
        {
            if (_capacity == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int changeCapacity(int v)
        {
            
            _capacity = v;

            return _capacity;
               
              
        }

    }
}
