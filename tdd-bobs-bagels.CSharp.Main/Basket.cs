using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_bobs_bagels.CSharp.Main
{
    public class Basket
    {
        public Basket(int bagelCapacity = 3)
        {
            BagelCapacity = bagelCapacity;
        }

        public int BagelCapacity { get; set; }

        public List<string> BasketList { get; set; } = new List<string>();

        public bool AddBagel(string name)
        {
            if (BasketList.Count >= BagelCapacity)
                return false;

            BasketList.Add(name);
            return true;
        }

        public bool RemoveBagel(string name)
        {
            if (BasketList.Contains(name))
            {
                BasketList.Remove(name);
                return true;
            }
            return false;
            
        }

        public void UpdateCapacity(int newCap)
        {
            //gonna ignore the bagels already added if the capacity is reduced :)
            BagelCapacity = newCap;
        }
    }
}
