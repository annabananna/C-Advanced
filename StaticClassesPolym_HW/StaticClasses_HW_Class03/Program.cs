using Models4;
namespace StaticClasses_HW_Class03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            foreach(Car c in VehicleDb.Cars)
            {
                Console.WriteLine(c.PrintVehicle());
            }
            foreach(Bike b in VehicleDb.Bikes)
            {
                Console.WriteLine(b.PrintVehicle());
            }
            foreach(Vehicle v in VehicleDb.Vehicles)
            {
                Console.WriteLine(v.PrintVehicle());
            }

            
            foreach(Car c in VehicleDb.Cars)
            {
                if(Validator.Validate(c) == true)
                {
                    Console.WriteLine("Successful validation");
                }
                else
                {
                    throw new Exception("Car inputs are not valid");
                }
            }

            if (Validator.Validate(VehicleDb.Cars[1]) == true)
            {
                Console.WriteLine($"Car {VehicleDb.Cars[1].Type} has valid inputs");
            }
            else
            {
                throw new Exception("Car inputs are not valid");
            }

            if (Validator.Validate(VehicleDb.Bikes[0]) == true)
            {
                Console.WriteLine($"Bike {VehicleDb.Bikes[0].Type} has valid inputs");
            }
            else
            {
                throw new Exception("Bike inputs are not valid");
            }

            if (Validator.Validate(VehicleDb.Vehicles[0]) == true)
            {
                Console.WriteLine($"Vehicle {VehicleDb.Vehicles[0].Type} has valid inputs");
            }
            else
            {
                throw new Exception("Vehicle inputs are not valid");
            }
        }
    }
}