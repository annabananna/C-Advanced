using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models4
{
    public class Car : Vehicle
    {
        public int FuelTank { get; set; }
        public List<string> Countries { get; set; }

        public override string PrintVehicle()
        {
            return base.Type + $" [{string.Join(", ", Countries)}]";
        }
    }
}
