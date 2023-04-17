using System.Reflection.Metadata;

namespace Generic_Extensions_HW1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Circle> circles = new List<Circle>() 
            { 
                new Circle {Id = 1, Radius = 2},
                new Circle {Id = 2, Radius = 5},
                new Circle {Id = 3, Radius = 7}
            };

            List<Rectangle> rectangles = new List<Rectangle>()
            {
                new Rectangle {Id = 1, SideA = 2, SideB = 6},
                new Rectangle {Id = 2, SideA = 3, SideB = 5},
                new Rectangle {Id = 3, SideA = 7, SideB = 4}
            };

            GenericDb<Circle> circleDb = new GenericDb<Circle>();
            GenericDb<Rectangle> rectangleDb = new GenericDb<Rectangle>();

            
            circleDb.PrintPerimeterForShapes(circles);
            rectangleDb.PrintPerimeterForShapes(rectangles);

            circleDb.PrintAreaForShapes(circles);
            rectangleDb.PrintAreaForShapes(rectangles);


            string circleInfo = "This shape is a circle";
            string rectangleInfo = "This shape is a rectangle";

            Console.WriteLine(circleInfo.PrintInfoShapes());
            Console.WriteLine(rectangleInfo.PrintInfoShapes());
        }
    }
}