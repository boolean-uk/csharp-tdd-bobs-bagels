using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tdd_bobs_bagels.CSharp.Main.Classes;

namespace Classes
{

    public class Basket
    {
        private int _capacity = 3; 
        private List<Bagel> _bagels = new List<Bagel>();

        public List<Bagel> Bagels { get => _bagels; }
        public int Capacity { get => _capacity; }

        public Basket() { }

        public string Add(Bagel bagel)
        {
            if ( _bagels.Count < Capacity)
            {
                _bagels.Add(bagel);
                return "";
            }
            return "Basket is full";
        }

        public string Remove(string type) 
        {
            int count = _bagels.Count;
            _bagels = _bagels.Where(b => b.Type != type).ToList();

            if (count < _bagels.Count) { return ""; }
            return "Could not find given bagel type";
        }

        public void SetCapacity(int capacity)
        {
            _capacity = capacity;
        }
    }
}
