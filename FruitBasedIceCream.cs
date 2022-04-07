using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IceCreamFactory
{
    class FruitBasedIceCream : IceCream 
    {
        private bool waffleServed;
        private string topping;

        public FruitBasedIceCream(int price, string flavour, bool waffleServed, string topping) : base(price, flavour)
        {
            WaffleServed = waffleServed;
            Topping = topping;
        }

        public bool WaffleServed { get { return waffleServed; } set { waffleServed = value; } }
        public string Topping { get { return topping; } set { topping = value; } }
        public override string ToString()
        {

            if (waffleServed == true)
            {
                return Flavour + " flavoured ice cream with " + Topping + ", topping, served in a waffle" + ", only " + Price + " zł";
            }
            else
            {
                return Flavour + " flavoured ice cream with " + Topping + " topping" + ", only " + Price + " zł";
            }
        }

    }
}
