﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    public class Basket
    { 

        public Dictionary<string, int> Bagels { get; set; } = new Dictionary<string, int>(3);

        
 
        public void AddBagel(string type, int price)
        {
            Bagels.Add(type, price);
            Console.WriteLine($"{type} bagel has been added to basket");
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
           if(Bagels.Count >= 3)
            {
                return true;
                Console.WriteLine("Basket is full");
            }
            else
            {
                return false;
                Console.WriteLine("Basket is not full");
            }
        }

        public void ChangeBasketCapacity()
        {
            throw new NotImplementedException();
        }













        

}
}
