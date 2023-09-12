﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_bobs_bagels.CSharp.Main
{
    public class Core
    {
        public List<string> items;
        public int capacity; 

        public Core(int initialCapacity =5) // added constructor for capacity and item list
        {
            capacity = initialCapacity;
            items = new List<string>();
        }
        public bool AddBagel(string bagelType)
        {
            if(items.Count < capacity)
            {
                items.Add(bagelType);
                return true;
            }
            return false;
        }

        public bool RemoveBagel(string bagelType)
        {
            if (items.Contains(bagelType))
            {
                items.Remove(bagelType);
                return true;
            }
            return false;
        }

        public bool IsFull()
        {
            return items.Count == capacity;
        }

        public void SetCapacity(int newCapacity)
        {
            capacity = newCapacity;
        }
    }
}
