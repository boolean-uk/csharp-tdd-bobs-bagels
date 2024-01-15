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
        private int _capacity = 3;

        public List<Bagel> Basket { get {  return _basket; } }
        public int Capacity { get { return _capacity; } }

        public void Add(Bagel bagel)
        {
            _basket.Add(bagel);
        }

        public void ChangeCapacity(int v)
        {
            throw new NotImplementedException();
        }

        public void Remove(Bagel bagel)
        {
            _basket.Remove(bagel);
        }
    }
}

public enum Bagel
{
    appleCinamon, blueberryChocolateChip, Egg, cinamonRaisin, everything,
    frenchToast, garlic, jalapeno, marbleOnion, poppy, plain, pumpernickle
}
