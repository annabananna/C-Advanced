using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Extensions_HW2
{
    public abstract class Pet
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int Age { get; set; }
        public abstract string PrintInfo();

        public Pet(string name, string type, int age)
        {
            Name = name;
            Type = type;
            Age = age;
        }
    }
}
