using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IceCreamFactory
{
    abstract class IceCream
    {
        protected int price;
        protected string flavour;
        public IceCream(int price, string flavour)
        {
            Price = price;
            Flavour = flavour;
        }
        public int Price { get { return price;  } set { price = value; } }
        public string Flavour { get { return flavour; } set { flavour = value; } }
        abstract public override string ToString();
       
    }
}
