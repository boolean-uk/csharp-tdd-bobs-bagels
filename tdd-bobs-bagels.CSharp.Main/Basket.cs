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
        private int _maxCapacity = 5;
        public readonly List<string> _basketList = new List<string>();

        public string Add(string bagelType)
        {
            throw new NotImplementedException();
        }
        public bool Remove(string bagelType)
        {
            throw new NotImplementedException();
            
        }
        public bool ChangeCapacity(int newCapacity)
        {
            throw new NotImplementedException();
        }
    }
}
