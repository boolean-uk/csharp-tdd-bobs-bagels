using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_bobs_bagels.CSharp.Main
{
    public class Basket
    {
        private List<string> _bagels = [];

        public void AddToBasket(string bagel)
        {
            Bagels.Add(bagel);
            
        }
        
        public List<string> Bagels { get { return _bagels; } set { _bagels = value; } }
    }
}
