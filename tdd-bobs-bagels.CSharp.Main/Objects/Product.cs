using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_bobs_bagels.CSharp.Main.Objects
{
    public abstract class Product : Object
    {
        private double _price = 20;

        public double Price { get => _price; }

        public double GetPrice()
        {
            return Price;
        }
    }
}
