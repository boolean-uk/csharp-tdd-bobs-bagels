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
        private int bagelCountLimit = 5;

        public List<string> getBagelList() 
        {
            return bagelList;
        }
        public void addBagel(String bagel) 
        {  
            //bagelList.Add(bagel);
        }

        public void removeBagel(String bagel) 
        {
            /*if (bagelList.Contains(bagel))
            {
                bagelList.Remove(bagel);
            }    
        */
        
        }
        
        public void adjustBasketCapacity(int capacity) 
        {
            //bagelCountLimit = capacity;
        }
    }
}
