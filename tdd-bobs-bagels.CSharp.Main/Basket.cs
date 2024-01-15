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
        private int _capacity = 4;
        public Basket() 
        {
            _bagles = new List<Bagle>();
        } 

        public bool Add(Bagle bagle)
        {
            if (_bagles.Count < _capacity)
            {
                _bagles.Add(bagle);
                return true;
            }
            Console.WriteLine("Your basket is full!");
            return false;
        }

        public bool Remove(string type)
        {
            throw new NotImplementedException();
        }
    }
}
