using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models4
{
    public static class Validator
    {
        public static bool Validate(Vehicle vehicle)
        {
            if(vehicle.Id == 0)
            {
                return false;
            }
            if(vehicle.Type.Length < 3)
            {
                return false;
            }
            if(vehicle.YearOfProduction == 0)
            {
                return false;
            }
            return true;
        }
    }
}
