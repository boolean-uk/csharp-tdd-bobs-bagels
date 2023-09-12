using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_bobs_bagels.CSharp.Main
{
    // internal class Bagel
    // {
    //     private string _type = "ABagelType";
    // 
    //     public string Type { get { return _type; } }
    // }

    public class Basket
    {
        private int _capacity = 3;
        private List<string> _basket = new List<string>();

        public bool Add(string bagel)
        {
            if (_basket.Count == _capacity)
                return false;
            _basket.Add(bagel);
            return true;
        }

        public bool Remove(string bagel)
        {
            return _basket.Remove(bagel);
        }

        public bool ChangeCapacity(int capacity, bool isManager)
        {
            throw new NotImplementedException();
        }

        public int BagelsNum { get => _basket.Count; }

        public int Capacity { get => _capacity; }
    }
}
