using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Extensions_HW1
{
    public class GenericDb<T> where T : Shape
    {
        public List<T> Db;

        public GenericDb()
        {
            Db = new List<T>();
        }
        public void PrintAreaForShapes(List<T> shapes)
        {
            foreach(T shape in shapes)
            {
                Console.WriteLine($"The area for the {shape.GetType().Name} is : {shape.GetArea()}");
            }
        }
        public void PrintPerimeterForShapes(List<T> shapes)
        {
            foreach(T shape in shapes)
            {
                Console.WriteLine($"The perimeter for the {shape.GetType().Name} is : {shape.GetPerimeter()} ");
            }
        }
    }
}
