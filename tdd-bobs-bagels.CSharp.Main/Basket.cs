using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_bobs_bagels.CSharp.Main
{
    public class Basket
    {
        private int capacity { get; set; } = 5; 
        public  List<string> basket { get; set; } = new List<string>();
        
        public bool Remove(string name) 
        {
            string? item = basket.Find(i => i == name);
            if (item != null)
            {
                basket.Remove(item);
                return true;
            }
            return false;
        }

        public bool Add(string name) 
        {
            if (basket.Count() < capacity) 
            {
                basket.Add(name);
                return true;
            }
            return false;
        }
        
    }
}
