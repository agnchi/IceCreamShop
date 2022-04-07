using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IceCreamFactory
{
    class Sorbet : IceCream
    {
        public Sorbet(int price, string flavour) : base(price, flavour)
        {
        }

        public override string ToString()
        {
            return Flavour + " flavoured sorbet, only " + Price + " zł";
        }
    }
}
