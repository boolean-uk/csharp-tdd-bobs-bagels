using Microsoft.VisualStudio.TestPlatform.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_bobs_bagels.CSharp.Main
{
    public class Basket
    {
        private List<string> _bagels = new List<string>();
        private int _capacity = 5;

        public int Capacity { set { _capacity = value; } }
        public List<string> Bagels { get { return _bagels; } }
        public bool AddBagel(string bagel)
        {
            if (Bagels.Count >= _capacity) return false;
            Bagels.Add(bagel);
            return true;
        }

        public bool RemoveBagel(string bagel)
        {
            return Bagels.Remove(bagel);
        }

    }
}
