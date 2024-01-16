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
            _customerID = ID;
            _items = new List<String>();
            _itemCapacityLimit = 5;
        }

        public void AddItem(String item)
        {
            if (HasAvailableSpace()) Items.Add(item);
            else throw new InvalidOperationException("You can not add more items when your basket has reach it's maximum capacity!");
        }

        public void RemoveItem(int itemIndex)
        {
            if (itemIndex >= 0 && itemIndex < Items.Count) Items.RemoveAt(itemIndex);
            else throw new InvalidOperationException("You are trying to remove a non-existent item.");
        }

        public bool HasAvailableSpace()
        {
            return Items.Count < _itemCapacityLimit;
        }

        public void SetItemCapacityLimit(int itemCapacityLimit)
        {
            _itemCapacityLimit = itemCapacityLimit;
        }

        public List<String> Items { get { return _items; } }
    }
}
