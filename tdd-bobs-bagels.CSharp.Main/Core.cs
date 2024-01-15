using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_bobs_bagels.CSharp.Main
{
    public class Core
    {
    }

    public class Basket
    {
        public List<string> _basket = new List<string>();

        public void Add(string bagel)
        {
            _basket.Add( bagel ) ;
        }

        public bool Remove(string bagel)
        {
            //throw new NotImplementedException();
            if (_basket.Contains(bagel)) { 
                _basket.Remove(bagel) ;
                return true;
            }
            else return false;  

        }
    }
}
