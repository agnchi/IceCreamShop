using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IceCreamFactory
{
    class IceCreamShop
    {
        private IceCreamFactory iceCreamFactory;

        public IceCreamFactory IceCreamFactory { get { return iceCreamFactory; } set { iceCreamFactory = value; } }
        public string AdvertiseDailySpecial(WeekDay day)
        {
            return iceCreamFactory.DailySpecial(day).ToString();
        }

    }
}
