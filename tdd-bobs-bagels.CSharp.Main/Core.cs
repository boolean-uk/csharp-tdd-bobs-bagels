using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_bobs_bagels.CSharp.Main
{
    public class BobsBasket
    {

        private List<string> _BobsBasket = new List<string>();
        private int _Basketsize = 5;

        public int basketSize { get { return _Basketsize;  } set { _Basketsize = value; } }


        public bool addBagel(string type, int amount)
        {
            if ((_BobsBasket.Count + amount) > basketSize)
            {
                return false;
            }
            else
            {
                for (int i = 0; i < amount; i++)
                {
                    _BobsBasket.Add(type);
                }
                return true;
            }
        }

        public void removeBagel (string type, int amount)
        {
            for (int i = 0; i < amount; i++)
            {
                _BobsBasket.Remove(type);
            }
        }

        public void changeBasketSize(int newSize)
        {
            basketSize = newSize;
        }

        public int roomForMoreBagels()
        {
            int current = basketSize - _BobsBasket.Count();
            return current;
        }

        public int maxAmountOfBagels()
        {
            return basketSize;
        }

    }
}
