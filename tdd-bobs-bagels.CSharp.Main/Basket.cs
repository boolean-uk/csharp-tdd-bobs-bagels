using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    public class Basket
    {

        public int Capacity { get; set; } = 3;


        public Dictionary<string, int> Bagels { get; set; } = new Dictionary<string, int>();

        
 
        public void AddBagel(string type, int price)
        {
            if (!IsBasketFull())
            {
                Bagels.Add(type, price);
                Console.WriteLine($"{type} bagel has been added to basket");
            }

        }

        public bool RemoveBagel(string type)
        {
            bool result = false;
            if (Bagels.ContainsKey(type))
            {
                Bagels.Remove(type);
                Console.WriteLine($"{type} bagel has been removed from basket");

            } else
            {
                Console.WriteLine("Bagel does not exists");
            }
            return result;
        }

        public bool IsBasketFull()
        {
           if(Bagels.Count >= Capacity)
            {
                Console.WriteLine("Basket is full");
                return true;
            }
            else
            {
                Console.WriteLine("Basket is not full");
                return false;
            }
        }

        public void ChangeBasketCapacity(int newCapacity)
        {
            if (Bagels.Count < newCapacity)
            {
                Capacity = newCapacity;
            }
        }













        

}
}
