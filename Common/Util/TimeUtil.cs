using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuelystText.Common.Util
{
    public class TimeUtil
    {
        public static DateTime GetCurrentUSATime()
        {
            DateTime dt = DateTime.Now;//北京时间
            DateTime newdt = dt.AddHours(-13);
            return newdt;
        }

        public static long GetCurrentUSATimeTick()
        {
            return GetCurrentUSATime().Ticks / 10000000;
        }

        public static string GetCurrentUSATimeYYMMDD()
        {
            return GetCurrentUSATime().ToString("yy-MM-dd");
        }
    }
}
