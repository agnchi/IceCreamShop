using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IceCreamFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            SmithIceCreamFactory smithIceCreamFactory = new SmithIceCreamFactory();
            RockIceCreamFactory rockIceCreamFactory = new RockIceCreamFactory();
            IceCreamShop iceCreamShop = new IceCreamShop();
            iceCreamShop.IceCreamFactory = smithIceCreamFactory;
            Console.WriteLine(WeekDay.Monday+": "+iceCreamShop.AdvertiseDailySpecial(WeekDay.Monday));
            Console.WriteLine(WeekDay.Tuesday + ": " + iceCreamShop.AdvertiseDailySpecial(WeekDay.Tuesday));
            Console.WriteLine(WeekDay.Wednesday + ": " + iceCreamShop.AdvertiseDailySpecial(WeekDay.Wednesday));
            iceCreamShop.IceCreamFactory = rockIceCreamFactory;
            Console.WriteLine(WeekDay.Thursday + ": " + iceCreamShop.AdvertiseDailySpecial(WeekDay.Thursday));
            Console.WriteLine(WeekDay.Friday + ": " + iceCreamShop.AdvertiseDailySpecial(WeekDay.Friday));
            Console.WriteLine(WeekDay.Saturday + ": " + iceCreamShop.AdvertiseDailySpecial(WeekDay.Saturday));
            Console.WriteLine(WeekDay.Sunday + ": " + iceCreamShop.AdvertiseDailySpecial(WeekDay.Sunday));


        }
    }
}
