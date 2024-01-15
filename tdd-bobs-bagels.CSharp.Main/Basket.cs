using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace tdd_bobs_bagels.CSharp.Main
{
    public class Basket
    {
        //set basket capacity, i.e list length
        List<string> basket = new List<string>();

        public Basket() 
        { 
            basket = new List<string>(); 
        }


        public bool addBagel(string bagelType)
        {
            return true;
        }

        public bool removeBagel(string bagelType)
        {
            return false;
        }


        public int changeCapacity(int newCapacity)
        {
            return 0;        
        }
    }
}



/*
 - class Basket()
  
 
 - Properties
public List<string> basket
public int basketCapacity


-Methods
bool add bageltype (string)
        adds a bagel to the basket, outputs true if bagel added and false otherwise
        If the basket is full, outputs a message saying the basket is full

bool remove bageltype (string)
        removes a bagel from the basket, outputs true if the bagel is removed and false otherwise
        If the item is not in the basket, outputs a message saying the item doesn't exist

int changeCapacity(int)
        changes the capacity of the basket, outputs the new integer capacity
 
 */