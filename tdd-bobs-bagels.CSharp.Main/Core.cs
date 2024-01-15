using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_bobs_bagels.CSharp.Main
{
    public enum Bagel { appleCinamon, blueberryChocolateChip, egg, cinamonRaisin, everything, 
        frenchToast, garlic, jalapeno, marbleOnion, poppy, plain, pumpernickle }

    public class Core
    {

        private int capacity = 3; 

        private List<Bagel> _bagels = new List<Bagel>();
        public List<Bagel> bagels { get { return _bagels; } }

        public Core() { }

        public bool Add(Bagel v)
        {
            if (bagels.Count >= capacity) return false;
            _bagels.Add(v);
            return true;
        }

        public void Remove(Bagel v)
        {
            _bagels.Remove(v);
        }

        public void changeCapacity(int v)
        {
            capacity = v;
        }
    }
}
