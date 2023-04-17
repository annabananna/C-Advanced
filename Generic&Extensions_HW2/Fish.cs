using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Extensions_HW2
{
    public class Fish : Pet
    {
        public string Color { get; set; }
        public int Size { get; set; }

        public Fish(string name, string type, int age, string color, int size) :
            base(name, type, age)
        {
            Color = color;
            Size = size;
        }
        public override string PrintInfo()
        {
            return $"{Name} is of type {Type}. Age {Age}. Color {Color} / Size {Size}";
        }
    }
}
