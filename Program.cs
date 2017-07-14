using System;

namespace vehicles
{
    public class IVehicle
    {
        string Propulsion { get; set; } 

        int PassengerCapacity { get; set; }

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
    public class JetSki : IVehicle, IwaterVehicle
    {
        public string Propulsion { get; set; }
        public int PassengerCapacity { get; set; }
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


    public class Motorcycle : IVehicle, IlandVehicle
    {
        public string Propulsion { get; set; }
        public int PassengerCapacity { get; set; }
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

    public class Cessna : IVehicle, IairVehicle
    {
        public string Propulsion { get; set; }
        public int PassengerCapacity { get; set; }
        public double MaxAirSpeed { get; set; }
        public bool Winged { get; set; }

        // constructor
        public Cessna (string propulsion, int passengers, double speed, bool wings)
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


    class Program
    {
        static void Main(string[] args)
        {
            JetSki honda = new JetSki("water jet", 3, 35);
            
        }
    }
}
