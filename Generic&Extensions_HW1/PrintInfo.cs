using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Extensions_HW1
{
    public static class PrintInfo
    {
        public static string PrintInfoShapes(this string text)
        {
            return "*****" + text + "******";
        }
    }
}
