using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_bobs_bagels.CSharp.Main
{
    public class Basket
    {
        public int _basketSize;
        public List<string> content;
        public Basket(int basketSize)
        {
            _basketSize = basketSize;
            content = new List<string>();
        }
        public bool addBagel(string type)
        {
            if(content.Count()<_basketSize)
            {
                content.Add(type);
                return true;
            }
            return false;
        }
        public bool removeBagel(string type)
        {
            foreach (string item in content)
            {
                if (item.Contains(type))
                {
                    content.Remove(item);
                    return true;
                }
            }
            return false;
        }
        public int changeCapacity(int currentSize)
        {
            return 0;
        }
    }

}
