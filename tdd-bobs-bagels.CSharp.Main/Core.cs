using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Sources;



namespace tdd_bobs_bagels.CSharp.Main
{
    public class Basket
    {
        //list that stores all bagels
        private List<String> bagelList = new List<String>();
        //limit of the capacity of bagels in the basket
        private int bagelCountLimit = 5;

        //function to get the bagel list
        public List<string> getBagelList() 
        {
            return bagelList;
        }

        //function to add bagels, if max capacity is'nt reached
        public void addBagel(String bagel) 
        {  
            if (bagelList.Count < bagelCountLimit) 
            {
                bagelList.Add(bagel);
            }
        }

        //function to remove bagels, if they exists in the basket
        public void removeBagel(String bagel) 
        {
            if (bagelList.Contains(bagel))
            {
                bagelList.Remove(bagel);
            }    
        }
        
        //adjust the capacity of the basket
        public void adjustBasketCapacity(int capacity) 
        {
            bagelCountLimit = capacity;
        }
    }
}
