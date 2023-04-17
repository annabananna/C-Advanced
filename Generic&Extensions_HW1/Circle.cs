using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Extensions_HW1
{
    public class Circle : Shape
    {
        public int Radius { get; set; }
        public override double GetArea()
        {
            return 3.14 * Radius * Radius;
        }
        public override double GetPerimeter()
        {
            return 2 * 3.14 * Radius;
        }
    }
}
