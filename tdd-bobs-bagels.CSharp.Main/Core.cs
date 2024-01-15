using NUnit.Framework.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_bobs_bagels.CSharp.Main
{
    public class Basket
    {

        public int Capacity { get; private set; }
        public List<string> Bagels { get; private set; }

        public Basket(int capacity)
        {
            Capacity = capacity;
            Bagels = new List<string>();
        }


        public void AddBagel(string bagelType)
        {
            if (!IsFull())
            {
                Bagels.Add(bagelType);
            }
            else
            {
                throw new InvalidOperationException("Basket is full. Cannot add more bagels.");
            }
        }

        public void RemoveBagel(string bagelType)
        {
            if (Bagels.Contains(bagelType))
            {
                Bagels.Remove(bagelType);
            }
            else
            {
                throw new InvalidOperationException($"{bagelType} not found in the basket.");
            }
        }


        public bool IsFull()
        {
            return Bagels.Count >= Capacity;
        }

        public void ChangeCapacity(int newCapacity)
        {
            Capacity = newCapacity;
        }


    }



    
}