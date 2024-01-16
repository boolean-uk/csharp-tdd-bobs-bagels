using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_bobs_bagels.CSharp.Main
{
    public class Core
    {
        public enum Bagel
        {
            Plain,
            Montreal,
            Salmon,
            Asiago,
            Sesame,
            Pumpernickel,
            GlutenFree
        }
        public int count;
        public int max;
        public List<Bagel> _cart;

        public Core()
        {
            _cart = new List<Bagel>();
            count = 0;
            max = 10;
        }

        public void AddBagel(Bagel b)
        {
            if (count < max)
            {
                _cart.Add(b);
                count++;
            }
            else
            {
                Console.WriteLine("Bag is full!");
            }
        }

        public void RemoveBagel(Bagel b)
        {
            if (CheckBagel(b))
            {
                _cart.Remove(b);
            }
            else { Console.WriteLine($"{b} is not in your cart"); }
        }

        public void IncreaseCapacity()
        {
            max = max * 2;
        }


        private bool CheckBagel(Bagel bagel)
        {
            bool bagelInCart = false;

            foreach (Bagel b in _cart)
            {
                if (b.Equals(bagel))
                {
                    bagelInCart = true;
                }
            }

            return bagelInCart;
        }
    }
}
