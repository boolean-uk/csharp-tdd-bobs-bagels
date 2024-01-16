using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_bobs_bagels.CSharp.Main
{
    public class Core
    {
        public List<string> bagel;
        int Bagel;
        int capacity;

        public Core()
        {
            bagel = new List<string>();
            Bagel= 0;
            capacity = 1;
        }

        public List<string> Bagels { get { return bagel; } }

        public void Add(string bagel)
        {
            if (Bagel != capacity)
            {
                Bagels.Add(bagel);
                Bagel++;
            }
            else
            {
                throw new Exception("Your basket is full");
            }

        }

        public void Remove(string bagel)
        {
            if (!Bagels.Remove(bagel))
            {
                throw new Exception("Bagel is not in basket");
            }
        }
        public void IncreaseCapacity()
        {
            capacity++;
        }

    }
}
