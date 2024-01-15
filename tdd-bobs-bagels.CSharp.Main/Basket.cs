using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
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
            public readonly BagleType bagleType;

            public Bagle(BagleType _bagleType)
            {
                bagleType = _bagleType;
            }
        }

       

        public List<Bagle> basket = new List<Bagle>();
        public int basketLimit = 4;


        public string AddBagleToBasket(BagleType type)
        {
            if(basket.Count >= basketLimit)
            {
                return new string($"Basket is full. Will not fit last {type} Bagle");
                
            }
            else
            {
                Bagle bagle = new Bagle(type);
                basket.Add(bagle);

                return new string($"{bagle.bagleType} Bagle added to basket");
            }
        }

        public string RemoveBagle(BagleType type) 
        {
            Bagle tempBagle = new Bagle(type);
            foreach (Bagle bagle in basket)
            {
                if (bagle.bagleType == tempBagle.bagleType)
                {
                    basket.Remove(bagle);
                    return new string($"{type} Bagle was removed from basket");
                }
            }

            return new string($"{type} Bagle does not exist in basket!");
            
        }

        public string ChangeBasketSize(int newBasketSize) 
        {
            int tempInt = basketLimit;
            basketLimit = newBasketSize;

            return new string($"basketsize was changed from {tempInt} to {basketLimit}");

        }
    }
}
