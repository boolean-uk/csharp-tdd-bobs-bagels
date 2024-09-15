using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_bobs_bagels.CSharp.Main.Interface
{
    public interface IBasketOperations
    {
        bool AlterSize(int newSize) 
        {
            return true;
        }
    }
}
