using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models4
{
    public class Bike : Vehicle    
    {
        public string Color { get; set; }

        public override string PrintVehicle()
        {
            return "Bike's year of production: " + base.YearOfProduction + $" Color: {Color}";
        }

    }
}
