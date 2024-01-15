using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_bobs_bagels.CSharp.Main
{
    public class Basket
    {
        public int _capacity;
        public List<string> _basket = new List<string>();
        public List<string> _bagels = new List<string> { "A", "B", "C" };

        public Basket()
        {

        }

        public void Add(string description)
        {
            if (_bagels.Contains(description))
            {
                _basket.Add(description);
            }

        }

        public void Remove(string description) 
        {
            
        }
    }
}
