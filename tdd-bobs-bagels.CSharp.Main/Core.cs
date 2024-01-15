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

        public bool Add(Bagel bagel)
        {
            if (!_basket.Contains(bagel))
            {
                _basket.Add(bagel);
                return true;
            }
            return false;
        }

        public bool Remove(Bagel bagel)
        {
            if (_basket.Contains(bagel))
            {
                _basket.Remove(bagel);
                return true;
            }
            
            return false;
        }

        public void ChangeCapacity(int cap)
        {
            _capacity = cap;
        }
    }
}

public enum Bagel
{
    appleCinamon, blueberryChocolateChip, Egg, cinamonRaisin, everything,
    frenchToast, garlic, jalapeno, marbleOnion, poppy, plain, pumpernickle
}
