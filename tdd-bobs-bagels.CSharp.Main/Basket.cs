using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_bobs_bagels.CSharp.Main
{
    public class Basket
    {
        public Dictionary<string, string> BagelsMenu;
        private int BasketCapacity;
        private List<string> BagelsInBasket;
        public Basket()
        {
            BagelsMenu = new Dictionary<string, string>();
            BagelsMenu.Add("vegan", "vegan bagel");
            BagelsMenu.Add("cream cheese", "cream cheese bagel");
            BagelsInBasket = new List<string>();
            BasketCapacity = 2;
        }
        public string Add(string bagelId)
        {
            if (BagelsInBasket.Count() == BasketCapacity)
            {
                return "Your basket is full";
            }
            if (BagelsMenu.ContainsKey(bagelId))
            {
                BagelsInBasket.Add(BagelsMenu[bagelId]);
                return $"{BagelsMenu[bagelId]} added to your basket";
            }
            return $"{bagelId} is not a bagel type on our menu";
        }

        public string Remove(string bagelId)
        {
            for (int i = 0; i < BagelsInBasket.Count(); i++)
            {
                if (BagelsInBasket[i] == BagelsMenu[bagelId])
                {
                    BagelsInBasket.RemoveAt(i);
                    return $"{BagelsMenu[bagelId]} removed from your basket";
                }
            }
            return "Cannot remove from basket since that bagel was not in your basket";
        }
        public string UpdateCapacity(int capacity)
        {
            if (capacity < 1)
            {
                return "basket capacity cannot be smaller than 1";
            }
            BasketCapacity = capacity;
            return $"New basket capacity is {capacity}";
        }
    }
}
