using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_bobs_bagels.CSharp.Main
{
    public class Basket
    {
        //private Basket _basket;
        private List<string> _ordersInBasket = new List<string>();

        public Basket()
        {
            _ordersInBasket = new List<string>();
        }
        public bool AddBagelToBasket(string bagel)
        {
            return false;
        }
        
    }
}
