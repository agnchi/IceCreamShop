using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IceCreamFactory
{
    class SmithIceCreamFactory : IceCreamFactory
    {
        public override IceCream DailySpecial(WeekDay day)
        {
            switch (day)
            {
                case WeekDay.Monday:
                    Sorbet kiwi_sorbet = new Sorbet(4,"kiwi");
                    return kiwi_sorbet;
                case WeekDay.Tuesday:
                    FruitBasedIceCream lemon_icecream = new FruitBasedIceCream(3,"lemon", false, "mango");
                    return lemon_icecream;
                case WeekDay.Wednesday:
                    GelatoIceCream almond_gelato = new GelatoIceCream(7, "almond", true, true);
                    return almond_gelato;
                case WeekDay.Thursday:
                    RegularIceCream vanilla_icecream=new RegularIceCream(3,"vanilla", true,"raspberry",false);
                    return vanilla_icecream;
                case WeekDay.Friday:
                    GelatoIceCream pistachio_gelato = new GelatoIceCream(8,"pistachio",false, false);
                    return pistachio_gelato;
                case WeekDay.Saturday:
                    Sorbet stwawberry_sorbet = new Sorbet(4,"strawberry");
                    return stwawberry_sorbet;
                case WeekDay.Sunday:
                    RegularIceCream chocolate_icecream = new RegularIceCream(5, "chocolate", true, "chocolate",true);
                    return chocolate_icecream;
                default:
                    return null;
            }
        }
    }
}
