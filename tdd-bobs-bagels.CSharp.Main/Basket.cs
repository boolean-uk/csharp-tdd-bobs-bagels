using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_bobs_bagels.CSharp.Main
{
    public class Basket
    {
        public List<string> content = new List<string>();

        public void add(string bagel)
        {
            content.Add(bagel);
        }
    }
}
