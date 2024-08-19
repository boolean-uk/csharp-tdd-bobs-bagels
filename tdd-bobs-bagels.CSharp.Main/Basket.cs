global using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_bobs_bagels.CSharp.Main {
    public class Basket
    {
        public int max_size { get; set; } = 3;

        private List<string> _bagels = new List<string>();

        public List<string> Bagels { get { return _bagels; } }
        public bool add(string bagel)
        {
            _bagels.Add(bagel);
            
            if (_bagels.Contains(bagel))
            {
                return true;
            }

            return false;
        }

        public bool remove(string bagel2)
        {
            _bagels.Remove(bagel2);

            if (_bagels.Contains(bagel2))
            {
                return false;
            }
            return true;
            
        }
        public bool basketisFull()
        {
            return _bagels.Count >= max_size;
        }

        public int changesize(int newCapasity)   
        {
            int newsize = 5;
            if (newsize > max_size)
            {
                newsize = max_size;
                return newsize;
            }
            return 0;
        }
          
        
        public bool CheckNotExisting()
        {
           string notExistingBagel = "Cheese";

            if (_bagels.Contains(notExistingBagel))
            {
                return true;
            }
            return false;

        }
            
            
        }

       




        

    }


   

