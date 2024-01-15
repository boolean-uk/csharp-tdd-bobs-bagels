using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_bobs_bagels.CSharp.Main.Classes
{
    public class Bagel
    {
        private string _type;

        public string Type { get => _type; }

        public Bagel(string type) 
        { 
            _type = type;
        }
    }
}
