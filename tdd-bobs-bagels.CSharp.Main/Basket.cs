using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_bobs_bagels.CSharp.Main
{
    public class Basket
    {
        private List<string> _items;

        public Basket()
        {
            _items = new List<string>();
        }

        public string AddProduct(string cheeseBagel)
        {
            throw new NotImplementedException();
        }

        public void ChangeCapacity(int v)
        {
            throw new NotImplementedException();
        }

        public List<string> GetItems()
        {
            return _items;
        }

        public string RemoveProduct(string cheeseBagel)
        {
            throw new NotImplementedException();
        }
    }
}
