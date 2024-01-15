using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_bobs_bagels.CSharp.Main
{
    public class Core
    {

        List<String> _bagels = new List<String>();

        public Core() { }

        public void add(string v)
        {
            _bagels.Add(v);
        }
    }
}
