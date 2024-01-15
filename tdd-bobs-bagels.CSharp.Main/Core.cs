using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_bobs_bagels.CSharp.Main
{
    public class Basket
    {
        private List<Bagel> _bagels = [];

        public void AddToBasket(Bagel bagel)
        {
            Bagels.Add(bagel);
            
        }
        
        public List<Bagel> Bagels { get { return _bagels; } set { _bagels = value; } }
    }
}
