using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IceCreamFactory
{
    class RockIceCreamFactory:IceCreamFactory
    {
        public override IceCream DailySpecial(WeekDay day)
        {
            switch (day)
            {
                case WeekDay.Monday:
                    
                    RegularIceCream peanut_icecream = new RegularIceCream(5, "peanut", true, "caramel", true);
                    return peanut_icecream;
                case WeekDay.Tuesday:
                    Sorbet mango_sorbet = new Sorbet(5, "mango");
                    return mango_sorbet;
                case WeekDay.Wednesday:
                    FruitBasedIceCream blueberry_icecream = new FruitBasedIceCream(5, "blueberry", true, "whipped cream");
                    return blueberry_icecream;
                case WeekDay.Thursday:
                    Sorbet peach_sorbet = new Sorbet(5, "peach");
                    return peach_sorbet;
                case WeekDay.Friday:
                    GelatoIceCream stracciatella_gelato = new GelatoIceCream(5, "stracciatella", true, false);
                    return stracciatella_gelato;
                case WeekDay.Saturday:
                    GelatoIceCream hazelnut_gelato = new GelatoIceCream(5, "hazelnut", false, true);
                    return hazelnut_gelato;
                case WeekDay.Sunday:
                    Sorbet pineapple_sorbet = new Sorbet(5, "pineapple");
                    return pineapple_sorbet;
                default:
                    return null;
            }
        }
    }
}
