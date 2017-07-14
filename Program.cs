using System;
using System.Collections.Generic;

namespace vehicles
{
    public class Vehicle
    {
        public string Propulsion { get; set; } 

        public int PassengerCapacity { get; set; }

        public virtual void VehicleOperation(){}

    }

    public interface IairVehicle
    {
        bool Winged { get; set; }
        double MaxAirSpeed { get; set; }
    }

    public interface IwaterVehicle
    {
        double MaxWaterSpeed { get; set; } 
    }

    public interface IlandVehicle
    {
        double MaxLandSpeed { get; set; }
    }

    //
    public class JetSki : Vehicle, IwaterVehicle
    {
        public double MaxWaterSpeed { get; set; }

        // constructor
        public JetSki (string propulsion, int passengers, double speed)
        {
            this.Propulsion = propulsion;
            this.PassengerCapacity = passengers;
            this.MaxWaterSpeed = speed;
        }
        public override void VehicleOperation()
        {
            Console.WriteLine("I propel people through the water");
        }
    }

    public class Yatch : Vehicle, IwaterVehicle
    {
        public double MaxWaterSpeed { get; set; }
        // constructor
        public Yatch (string propulsion, int passengers, double speed)
        {
            this.Propulsion = propulsion;
            this.PassengerCapacity = passengers;
            this.MaxWaterSpeed = speed;
        }
         public override void VehicleOperation()
        {
            Console.WriteLine("I propel people through the water with style");
        }
    }


    public class Motorcycle : Vehicle, IlandVehicle
    {
        public double MaxLandSpeed { get; set; }

        // constructor
        public Motorcycle (string propulsion, int passengers, double speed)
        {
            this.Propulsion = propulsion;
            this.PassengerCapacity = passengers;
            this.MaxLandSpeed = speed;
        }

        public override void VehicleOperation()
        {
            Console.WriteLine("I propel people on land with incredible acceleration");
        }
    }

    public class Car : Vehicle, IlandVehicle
    {
        public double MaxLandSpeed { get; set; }
        // constructor
        public Car (string propulsion, int passengers, double speed)
        {
            this.Propulsion = propulsion;
            this.PassengerCapacity = passengers;
            this.MaxLandSpeed = speed;
        }
        public override void VehicleOperation()
        {
            Console.WriteLine("I propel people on land and can go many places");
        }
    }

    public class Airplane : Vehicle, IairVehicle
    {
        public double MaxAirSpeed { get; set; }
        public bool Winged { get; set; }

        // constructor
        public Airplane (string propulsion, int passengers, double speed, bool wings)
        {
            this.Propulsion = propulsion;
            this.PassengerCapacity = passengers;
            this.MaxAirSpeed = speed;
            this.Winged = wings;
        }
        public override void VehicleOperation()
        {
            Console.WriteLine("I propel people through the air like a majestic bird");
        }
    }

    public class Helicopter : Vehicle, IairVehicle
    {
        public bool Winged { get; set; }
        public double MaxAirSpeed { get; set; }
        // constructor
        public Helicopter (string propulsion, int passengers, double speed, bool wings)
        {
            this.Propulsion = propulsion;
            this.PassengerCapacity = passengers;
            this.MaxAirSpeed = speed;
            this.Winged = wings;
        }
        public override void VehicleOperation()
        {
            Console.WriteLine("I take off vertically");
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            
            // Build a collection of all vehicles that fly
            Airplane cessna = new Airplane("propeller", 4, 150, true);
            Helicopter blackhawk = new Helicopter("Main rotor and Tail rotor", 6, 100, false);
            List<Vehicle> airVehicles = new List<Vehicle>();
            airVehicles.Add(cessna);
            airVehicles.Add(blackhawk);
            
            // With a single `foreach`, have each vehicle Fly()
            foreach (var item in airVehicles) {
                Console.WriteLine($"my method of propulsion is {item.Propulsion} and I can carry {item.PassengerCapacity} passengers.");
                item.VehicleOperation();
                // I can't reference any property or method that is specific to different classes (line 146-147) even if they are both of class Vehicle and interface IairVehicle
            }
            Console.WriteLine("\n");

            // Build a collection of all vehicles that operate on roads
            Motorcycle CBR600RR = new Motorcycle("inline4 engine", 2, 180);
            Car subaru = new Car("inline 4 engie and AWD", 5, 120);
            List<IlandVehicle> landVehicles = new List<IlandVehicle>();
            landVehicles.Add(CBR600RR);
            landVehicles.Add(subaru);

            // With a single `foreach`, have each road vehicle Drive()
            foreach (Vehicle item in landVehicles) {
                item.VehicleOperation();
            }
            Console.WriteLine("\n");
            

            // Build a collection of all vehicles that operate on water
            JetSki honda = new JetSki("water jet", 3, 35);
            Yatch allGold = new Yatch("twin water jet", 20, 30);
            List<Vehicle> waterVehicles = new List<Vehicle>();
            waterVehicles.Add(honda);
            waterVehicles.Add(allGold);

            // With a single `foreach`, have each water vehicle Drive()
            foreach (Vehicle item in waterVehicles) {
                item.VehicleOperation();
            }
                
        }
    }
}
