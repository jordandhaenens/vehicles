using System;

namespace vehicles
{
    public interface IVehicle
    {
        string Propulsion { get; set; } 
        int Doors { get; set; } 
        int PassengerCapacity { get; set; }
        bool Winged { get; set; } //air vehicle
        // string TransmissionType { get; set; }
        // double EngineVolume { get; set; }
        double MaxWaterSpeed { get; set; } //water vehicle
        double MaxLandSpeed { get; set; } //land vehicle
        double MaxAirSpeed { get; set; } // air vehicle
        // void Start();
        // void Stop();
        // void Drive(); 
        // void Fly();
        void vehicleOperation();

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
