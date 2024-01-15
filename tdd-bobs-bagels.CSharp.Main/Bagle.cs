using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_bobs_bagels.CSharp.Main
{
    public class Bagle
    {
        private string _name;
        public string Name { get { return _name; } }
        public Bagle(string name)
        {
            _name = name;
        }
    }
}
