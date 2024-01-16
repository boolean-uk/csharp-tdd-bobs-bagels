using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tdd_bobs_bagels.CSharp.Main.Objects.Core;
using tdd_bobs_bagels.CSharp.Main.Objects;
using tdd_bobs_bagels.CSharp.Main.Interface;

namespace Objects.People
{
    public class Manager : Person, IBasketOperations
    {
        public static Basket Basket = new Basket();

        public bool AlterSize(Basket basket, int newSize)
        {
            return basket.AlterSize(newSize);
        }
    }
}
