using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_bobs_bagels.CSharp.Main
{
    public class Basket
    {
        private List<Bagle> _bagles;

        public Basket() 
        {
            _bagles = new List<Bagle>();
        } 

        public bool Add(Bagle bagle)
        {
            _bagles.Add(bagle);
            return true;
        }

    }
}
