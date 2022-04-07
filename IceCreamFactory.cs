using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IceCreamFactory
{
    abstract class IceCreamFactory
    {
        abstract public IceCream DailySpecial(WeekDay day);
    }
}
