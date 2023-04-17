using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Extensions_HW1
{
    public class Rectangle : Shape
    {
        public int SideA { get; set; }
        public int SideB { get; set; }
        public override double GetArea()
        {
            return SideA * SideB;
        }
        public override double GetPerimeter()
        {
            return 2 * (SideA + SideB);
        }
    }
}
