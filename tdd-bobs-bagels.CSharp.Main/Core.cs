using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_bobs_bagels.CSharp.Main
{
    public enum Bagel { appleCinamon, blueberryChocolateChip, Egg, cinamonRaisin, everything, 
        frenchToast, garlic, jalapeno, marbleOnion, poppy, plain, pumpernickle }

    public class Core
    {

        private List<Bagel> _bagels = new List<Bagel>();
        public List<Bagel> bagels { get { return _bagels; } }

        public Core() { }

        public bool Add(Bagel v)
        {
            _bagels.Add(v);
            return true;
        }

        public void Remove(Bagel v)
        {
            _bagels.Remove(v);
        }
    }
}
