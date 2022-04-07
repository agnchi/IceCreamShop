using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IceCreamFactory
{
    class RegularIceCream:IceCream
    {
        private bool waffleServed;
        private string topping;
        private bool chocolateSprinklesAdded;

        public RegularIceCream(int price, string flavour, bool waffleServed, string topping, bool chocolateSprinklesAdded) : base(price, flavour)
        {
            WaffleServed = waffleServed;
            Topping = topping;
            ChocolateSprinklesAdded = chocolateSprinklesAdded;
        }

        public bool WaffleServed { get { return waffleServed; } set { waffleServed = value; } }
        public string Topping { get { return topping; } set { topping = value; } }
        public bool ChocolateSprinklesAdded { get { return chocolateSprinklesAdded; } set { chocolateSprinklesAdded = value; } }

        public override string ToString()
        {
            
            if(ChocolateSprinklesAdded ==true && waffleServed==false )
            {
                return Flavour + " flavoured ice cream with " + Topping + "topping and chocolate sprinckles" + ", only " + Price + " zł";
            }

            if (ChocolateSprinklesAdded == true && waffleServed == true)
            {
                return Flavour + " flavoured ice cream with " + Topping + "topping and chocolate sprinckles, served in a waffle" + ", only " + Price + " zł";
            }
            if (ChocolateSprinklesAdded == false && waffleServed == true)
            {
                return Flavour + " flavoured ice cream with " + Topping + "topping, served in a waffle" + ", only " + Price + " zł";
            }
            else
            {
                return Flavour + " flavoured ice cream with " + Topping + "topping" + ", only " + Price + " zł";
            }
        }


    }
}
