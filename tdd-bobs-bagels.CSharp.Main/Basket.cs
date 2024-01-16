using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace tdd_bobs_bagels.CSharp.Main
{
    public class Basket
    {
        private int _customerID;
        private int _itemCapacityLimit;
        private List<String> _items;

        public Basket(int ID)
        {
            throw new NotImplementedException();
        }

        public void AddItem(String item)
        {
            throw new NotImplementedException();
        }

        public void RemoveItem(int itemIndex)
        {
            throw new NotImplementedException();
        }

        public bool HasAvailableSpace()
        {
            throw new NotImplementedException();
        }

        public void SetItemCapacityLimit(int itemCapacityLimit)
        {
            throw new NotImplementedException();
        }

        public List<String> Items { get { throw new NotImplementedException(); } }
    }
}
