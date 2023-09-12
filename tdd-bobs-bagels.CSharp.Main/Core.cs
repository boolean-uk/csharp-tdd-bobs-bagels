using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_bobs_bagels.CSharp.Main
{
    // internal class Bagel
    // {
    //     private string _type = "ABagelType";
    // 
    //     public string Type { get { return _type; } }
    // }

    public class Basket
    {
        private int _capacity = 3;
        private List<string> _basket = new List<string>();

        public bool add(string bagel)
        {
            throw new NotImplementedException();
        }
    }
}
