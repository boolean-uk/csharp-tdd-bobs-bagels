using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    public class Basket
{
        public int Capacity { get; set; } = 3;


        public Dictionary<string, int> Bagels { get; set; } = new Dictionary<string, int>(3);
        
 
        public void AddBagel(string type, int value 2)
        {
            Bagels.Add(type, );
        }

        public bool RemoveBagel(string type)
        {
            throw new NotImplementedException();
        }

        public bool IsBaketFull()
        {
            throw new NotImplementedException();
        }

        public void ChangeBasketCapacity()
        {
            throw new NotImplementedException();
        }













        

}
}
