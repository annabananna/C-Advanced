using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models4
{
    public static class VehicleDb
    {
        public static List<Car> Cars;
        public static List<Bike> Bikes;
        public static List<Vehicle> Vehicles;

        static VehicleDb()
        {
            Cars = new List<Car>
            {
                new Car()
                {
                    Id = 45455,
                    Type = "Puegeot",
                    YearOfProduction = 2017,
                    BatchNumber = "AB38838383",
                    FuelTank = 20,
                    Countries = new List<string>{"France", "Slovakia" }
                },
                new Car()
                {
                    Id = 5454, 
                    Type = "Mazda",
                    YearOfProduction = 2020,
                    BatchNumber = "DK4548932",
                    FuelTank = 25,
                    Countries = new List<string>{"Japan", "Michigan", "Germany" }
                }
            };

            Bikes = new List<Bike>
            {
                new Bike()
                {
                    Id = 53,
                    Type = "Polar",
                    YearOfProduction = 2019,
                    BatchNumber = "A5454B",
                    Color = "Pink"
                },
                new Bike()
                {
                    Id = 66,
                    Type = "Scott",
                    YearOfProduction = 2021,
                    BatchNumber = "MB4d45D",
                    Color = "White"
                },
                new Bike()
                {
                    Id = 77,
                    Type = "Ghost",
                    YearOfProduction = 2018,
                    BatchNumber = "V545455A",
                    Color = "Blue"
                }
            };
            Vehicles = new List<Vehicle>
            {
                new Vehicle()
                {
                    Id = 86464,
                    Type = "Van",
                    YearOfProduction = 2011,
                    BatchNumber = "HGH4456351",
                },
                new Vehicle()
                {
                    Id = 45464,
                    Type = "Truck",
                    YearOfProduction = 2013,
                    BatchNumber = "GFFH2131"
                }
            };
        }
    }
}
