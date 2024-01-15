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
        private int _basketSize;

        public Basket(int basketSize) 
        {
            _basketSize = basketSize;
        }

        public void AddToBasket(Bagel bagel)
        {
            if (BasketSize == 0)
            {
                throw new ArgumentException("No more room in basket");
            }
            Bagels.Add(bagel);
            BasketSize -= 1;
            
        }
        
        public List<Bagel> Bagels { get { return _bagels; } set { _bagels = value; } }
        public int BasketSize { get { return _basketSize; } set { _basketSize = value; } }
    }
}
