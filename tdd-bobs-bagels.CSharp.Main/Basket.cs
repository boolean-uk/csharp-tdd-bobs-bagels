using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_bobs_bagels.CSharp.Main
{
    public class Basket
    {
        public enum Bagel
        {
            Plain, Everything, Egg, Sourdough, Blueberry, Montreal, 
            Cinnamon, Salt, Sesame
        }
        private int basketSize = 3;
        private List<Bagel> basket = new List<Bagel>(); 
        public List<Bagel> GetBasket() { return basket; }

        public string AddBagel(Bagel bagel)
        {
            if (basket.Count < basketSize && Enum.IsDefined(typeof(Bagel), bagel))
            {
                basket.Add(bagel);
                return "Bagel added to the basket.";
            }
            else if (basket.Count >= basketSize) 
            {
                return "Basket is full.";
            }
            else { return "Error";  } 
        }
    }
}
