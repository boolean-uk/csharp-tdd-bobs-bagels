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

            return "";
        }

        public string Remove(string type) 
        {

            return "";
        }

        public void SetCapacity(int capacity)
        {

        }
    }
}
