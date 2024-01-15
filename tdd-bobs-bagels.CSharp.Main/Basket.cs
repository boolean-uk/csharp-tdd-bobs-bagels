using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static tdd_bobs_bagels.CSharp.Main.Basket;

namespace tdd_bobs_bagels.CSharp.Main
{
    public class Basket
    {
        public enum BagleType
        {
            Plain,
            Sourdough,
            Gluten_free
        }

        public struct Bagle
        {
            private BagleType bagleType;

            Bagle(BagleType _bagleType)
            {
                bagleType = _bagleType;
            }
        }

        public List<Bagle> basket;
        public int basketLimit = 4;


        public string AddBagleToBasket(BagleType type)
        {
            throw new NotImplementedException();
        }

        public string RemoveBagle(BagleType type) 
        { 
            throw new NotImplementedException(); 
        }

        public string ChangeBasketSize(int newBasketSize) 
        { 
            throw new NotImplementedException(); 
        }
    }
}
