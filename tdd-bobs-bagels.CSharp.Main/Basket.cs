using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_bobs_bagels.CSharp.Main
{
    public class Basket
    {
        private List<string> _bagels = new List<string>();
        private int _basketCapacity = 10;
        
        public string Add(string bagelName)
        {
            if (_basketCapacity <= 0)
            {
                return $"There is no space for {bagelName}";
            } else
            {
                _bagels.Add(bagelName);
                BasketCapacity -= 1;
                return $"Successfully added {bagelName}";
            }  
        }

        public string Remove(string bagelName)
        {
            if (_bagels.Contains(bagelName))
            {
                _bagels.Remove(bagelName);
                BasketCapacity += 1;
                return $"{bagelName} successfully removed.";
            }
            else
            {
                return $"{bagelName} does not exist.";
            }
        }

        public List<string> Bagels { get { return this._bagels; } }
        public int BasketCapacity { get { return this._basketCapacity; } set { this._basketCapacity = value; } }
    }
}
