using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_bobs_bagels.CSharp.Main
{
    public class Bagel
{
        private string _type;

        public Bagel(string type)
        {
            _type = type;
        }

        public string Type { get { return _type; } set {  _type = value; } }
}
}
