using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IceCreamFactory
{
    class GelatoIceCream:IceCream
    {
        private bool waffleServed;
        private bool chocolateSprinklesAdded;

        public GelatoIceCream(int price, string flavour, bool waffleServed, bool chocolateSprinklesAdded) : base(price, flavour)
        {
            WaffleServed = waffleServed;
            ChocolateSprinklesAdded = chocolateSprinklesAdded;
        }

        public bool WaffleServed { get { return waffleServed; } set { waffleServed = value; } }
        public bool ChocolateSprinklesAdded { get { return chocolateSprinklesAdded; } set { chocolateSprinklesAdded = value; } }
        public override string ToString()
        {

            if (ChocolateSprinklesAdded == true && waffleServed == false)
            {
                return Flavour + " flavoured gelato ice cream with chocolate sprinckles" + ", only " + Price + " zł";
            }

            if (ChocolateSprinklesAdded == true && waffleServed == true)
            {
                return Flavour + " flavoured gelato ice cream with chocolate sprinckles, served in a waffle" + ", only " + Price + " zł";
            }
            if (ChocolateSprinklesAdded == false && waffleServed == true)
            {
                return Flavour + " flavoured gelato ice cream, served in a waffle" + ", only " + Price + " zł";
            }
            else
            {
                return Flavour + " flavoured gelato ice cream with, only " + Price + " zł";
            }
        }
    }
}
