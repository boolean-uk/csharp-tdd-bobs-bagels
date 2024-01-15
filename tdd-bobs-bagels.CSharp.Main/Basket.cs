using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_bobs_bagels.CSharp.Main
{
    public class Basket
    {
        public readonly string[] bagelTypes = { "plain", "sesameSeed", "blueberry", "jalapeno" };
        private int _maxCapacity = 4;
        public readonly List<string> _basketList = new List<string>();

        public string Add(string bagelType)
        {
            if (_basketList.Count >= _maxCapacity) return "Basket is full";
            else if (Array.IndexOf(bagelTypes, bagelType) != -1){
                _basketList.Add(bagelType);
                return $"{bagelType} was added to basket";
            } 
            else{
                return $"{bagelType} is not a valid bagle type";
            }
            
        }

        public bool Remove(string bagelType)
        {
            bool wasItemRemoved = _basketList.Remove(bagelType);
            return wasItemRemoved;
        }

        public bool ChangeCapacity(int newCapacity)
        {
            if(newCapacity < 1 ||  newCapacity < _basketList.Count -1)
            {
                return false;
            }
            else
            {
                _maxCapacity = newCapacity;
                return true;
            }
        }
    }
}
