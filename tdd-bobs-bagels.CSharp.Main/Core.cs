using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_bobs_bagels.CSharp.Main
{
    public class Core
    {
        private List<Bagel> _basket = new List<Bagel>();
        public List<Bagel> Basket { get {  return _basket; } }
        public void Add(Bagel bagel1)
        {
            throw new NotImplementedException();
        }
    }
}

public enum Bagel
{
    appleCinamon, blueberryChocolateChip, Egg, cinamonRaisin, everything,
    frenchToast, garlic, jalapeno, marbleOnion, poppy, plain, pumpernickle
}
