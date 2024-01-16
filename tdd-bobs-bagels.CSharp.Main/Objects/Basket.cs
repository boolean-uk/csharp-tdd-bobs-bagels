using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_bobs_bagels.CSharp.Main.Objects
{
    public class Basket : Object
    {
        List<Product> _contentsInBasket = new List<Product>();

        public int BasketSize { get => _contentsInBasket.Capacity; set => _contentsInBasket.Capacity = value; }
        private int _basketSizeLimit = 50;

        public Basket()
        {
            _contentsInBasket.Capacity = 10;
        }

        public bool AddProduct(Product product)
        {
            if (product == null)
                return false;

            _contentsInBasket.Add(product);
            return true;
        }
        public bool RemoveProduct(Product product)
        {
            if (product == null)
                return false;

            return _contentsInBasket.Remove(product);
        }

        protected internal bool AlterSize(int newSize)
        {
            if (newSize < 0 || newSize > _basketSizeLimit)
                return false;

            BasketSize = newSize;
            return true;
        }
    }
}