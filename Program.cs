using System;

namespace vehicles
{
    public interface IVehicle
    {
        string Propulsion { get; set; } 
        // int Doors { get; set; } 
        int PassengerCapacity { get; set; }
        // bool Winged { get; set; } //air vehicle
        // string TransmissionType { get; set; }
        // double EngineVolume { get; set; }
        // void Start();
        // void Stop();
        // void Drive(); 
        // void Fly();
        void VehicleOperation();

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
        public double MaxWaterSpeed { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        // constructor
        public JetSki (string value, int cap)
        {
            this.Propulsion = value;
            this.PassengerCapacity = cap;
        }

        public void VehicleOperation()
        {
            Console.WriteLine("I propel people through the water");
        }
    }


    public class Motorcycle : IVehicle, IlandVehicle
    {
        public string Propulsion { get; set; }
        public int PassengerCapacity { get; set; }
        public double MaxLandSpeed { get; set; }

        public void VehicleOperation()
        {
            Console.WriteLine("I propel people on land with incredible acceleration");
        }
    }

    public class Cessna : IVehicle, IairVehicle
    {
        public string Propulsion { get; set; }
        public int PassengerCapacity { get; set; }
        public bool Winged { get; set; }
        public double MaxAirSpeed { get; set; }
        public void VehicleOperation()
        {
            Console.WriteLine("I propel people through the air like a bird");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            JetSki honda = new JetSki("water jet", 3);
            
        }
    }
}
