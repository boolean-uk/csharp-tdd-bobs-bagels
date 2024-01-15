using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_bobs_bagels.CSharp.Main
{
    public class Core
    {
        public List<string> Basket = new List<string>();

        public int MaxCapacity { get; set; } = 3;

        public string AddBagel(string bagel)
        {
            if (Basket.Count < MaxCapacity)
            {
                Basket.Add(bagel);
                return "Bagel added";
            } else
            {
                return "Basket is full";
            }
            
        }

        public string RemoveBagel(string bagel)
        {
            if (Basket.Contains(bagel))
            {
                Basket.Remove(bagel);
                return "Bagel removed";
            } else
            {
                return "You can't remove a bagel that doesn't exist!";
            }
        }

        private string secretCode { get; } = "thesecretcode";
        public int EditMaximum(string managerCode, int newCapacity)
        {
            if (managerCode == secretCode)
            {
                MaxCapacity = newCapacity;
            }
            return MaxCapacity;
        }
    }
}
