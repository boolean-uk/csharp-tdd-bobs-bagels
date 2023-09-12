using Microsoft.VisualStudio.TestPlatform.Common.Interfaces;
using NUnit.Framework.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_bobs_bagels.CSharp.Main
{
    public class Core
    {
        public List<string> basket = new List<string>();
        public int capacity = 5;
        private bool _isManager = false;

        public string AddBagel(List<String> basket, String bagel)
        {
            this.basket = basket;
            if(basket.Count < capacity)
            {
                basket.Add(bagel);
                return "bagel added!";
            }
            return "basket is full!";
        }

        public string RemoveBagel(List<string> basket, string bagel)
        {
            throw new NotImplementedException();
        }

        public void UpdateCapacity(List<string> basket, int newcap)
        {
            throw new NotImplementedException();
        }
    }
}
