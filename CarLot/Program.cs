using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace CarLot
{
    class Program
    {
        static void Main(string[] args)
        {
            CarLot carlot1 = new CarLot("Average Joe's Cars");
            carlot1.AddVehicles(new Car("H8Karen", "toyota", "prius", 20_000, false));
            carlot1.AddVehicles(new Truck("H8INC", "Toyota", "4x4", 30_000, "long"));

        }
    }
    class Vehicle
    {
        public string LicenseNumber { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }

        public Vehicle(string license, string make, string model, decimal price)
        {
            LicenseNumber = license;
            Make = make;
            Model = model;
            Price = price;
        }
    }
    class Car : Vehicle
    {
        public bool HasSunroof { get; set; }
        public Car(string license, string make, string model, decimal price, bool sunroof) : base(license, make, model, price)
        {
            HasSunroof = sunroof;
        }
    }
    class Truck : Vehicle
    {
        public string BedSize { get; set; }

        public Truck(string license, string make, string model, decimal price, string size) : base(license, make, model, price)
        {
            BedSize = size;
        }
    }
    class CarLot
    {
        public string Name { get; set; }
        List<Vehicle> vehicles = new List<Vehicle>();
        public CarLot(string name)
        {
            Name = name;
        }
        
        public void AddVehicles(Vehicle vehicle)
        {
            vehicles.Add(vehicle);
        }
        public List<Vehicle> GetVehicles() 
        {
            return vehicles;
        }
    }
}
