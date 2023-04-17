using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Extensions_HW2
{
    public class Dog : Pet
    {
        public string FavoriteFood { get; set; }

        public Dog(string name, string type, int age, string favoriteFood) :
            base(name, type, age)
        {
            FavoriteFood = favoriteFood;
        }

        public override string PrintInfo()
        {
            return $"{Name} is of type {Type}. Age {Age} and it's favourite food is: {FavoriteFood}";
        }
    }
}
