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
        
 
        public void AddBagel(string type, int price)
        {
            Bagels.Add(type, price);
        }

        public bool RemoveBagel(string type)
        {
            bool result = false;
            if (Bagels.ContainsKey(type))
            {
                Bagels.Remove(type);

            } else
            {
                Console.WriteLine("Bagel does not exists");
            }
            return result;
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
