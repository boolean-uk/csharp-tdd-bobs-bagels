using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_bobs_bagels.CSharp.Main
{
    public class BagelBasket
{
        public List<string> bagles = new List<string>();

        public int Capacity { get; set; } = 1;

        public bool add(string bagel)
        {
            if (bagles.Count < Capacity)
            {

            bagles.Add(bagel);
            return true;

            }

            return false;
        }

        public bool remove(string bagel)
        {
            if (bagles.Contains(bagel))
            {
                bagles.Remove(bagel);
                return true;
            }

            return false;
        }

    }
}
