using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_bobs_bagels.CSharp.Main
{
    public class Basket
    {
        public int _capacity = 5;
        public List<string> _basket = new List<string>();
        public List<string> _bagels = new List<string> { "A", "B", "C" };

        public Basket()
        {

        }

        public void Add(string description)
        {
            if ( _bagels.Contains(description) && _basket.Count < _capacity )
            {
      
                _basket.Add(description);
            }
            else
            {
                Console.Write("Basket size exceeded!");
            }

        }

        public void Remove(string description) 
        {
            if (_basket.Contains(description)) 
            {
                _basket.Remove(description);
            }
            else
            {
                Console.Write($"Bagel {description} not in the basket!");
            }
        }

        public void ChangeCapacity(int new_capacity)
        {
            this._capacity = new_capacity;
        }
    }
}
