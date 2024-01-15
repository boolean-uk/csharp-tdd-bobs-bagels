using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace tdd_bobs_bagels.CSharp.Main
{
    public class Basket
    {
        Dictionary<string, int> _basket;
        int _capacity;

        int _totalInBasket;

        public Basket() {
            _basket = new Dictionary<string, int>();
            _capacity = 5;
            _totalInBasket = 0;
            _basket.Add("Bagel", 0);
            _basket.Add("Sugar", 0);
            _basket.Add("Vegan", 0);
            _basket.Add("Chocolate", 0);
        }

        public bool AddBagel(string type) {
            if (_capacity + 1 >= _totalInBasket)
                return false;
            if(!_basket.ContainsKey(type) && type != "") {
                _basket.Add(type, 1);
                _totalInBasket += 1;
                return true;
            }
            if(_basket.ContainsKey(type)) {
                _basket[type] += 1;
                _totalInBasket += 1;
            }
            return false;
        }

        public bool RemoveBagel(string name) {
            if(name == "")
                return false;
            if(_totalInBasket >= _capacity)
                return false;
            if(_basket.ContainsKey(name)) {
                _basket[name] -= 1;
                return true;
            }
            return false;
        }

        public bool IsBasketFull() {
            if (_totalInBasket == _capacity)
                return true;
            return false;
        }

        public bool ChangeCapacity(int capacity) {
            if(_totalInBasket <= capacity) {
                _capacity = capacity;
                return true;
            }
            return false;
        }
    }
}
