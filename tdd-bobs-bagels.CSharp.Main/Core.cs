using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_bobs_bagels.CSharp.Main
{
    public class Core
    {
        public int _capacity = 2;
        public List<string> _basketList;

        public Core() 
        {
            _basketList = new List<string>(_capacity);
        }

        public List<string> _BasketList { get {  return _basketList; } }
        public int Capacity { get; set; }
       
        public bool AddBagel(string bagel)
        {
            if(_BasketList.Count > _capacity) 
            {
                Console.WriteLine("Basket is full");
                return false;
            }
            else
            {
                _basketList.Add(bagel);
                return true;
            }
                
        }


        public void RemoveBagel(string bagel)
        {
            if (_basketList.Contains(bagel))
            {
                _basketList.Remove(bagel);
            }
            else
            {
                BagelNotInBasket(bagel);
            }
        }
        public void basketCapacity(int size)
        {
            _capacity = size;
        }

        public string BagelNotInBasket(string bagel)
        {
            return ($"{bagel} is not in the basket");
        }

        
    }
}
