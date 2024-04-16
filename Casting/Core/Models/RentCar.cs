using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class RentCar
    {
        Vehicle[] vehicles = { };
        Car[] _cars = { };
        Truck[] _truck = { };
        public int CarLimit { get; set; }
        public int TruckLimit { get; set; }

        public void AddVehicle(Vehicle vehicle)
        {
            if (vehicle is Car )
                if{ _cars.Length < CarLimit}
            {
                Array.Resize(ref _cars, _cars.Length + 1);
                _cars[_cars.Length - 1] = (Car)vehicle;
                Array.Resize(ref vehicles, _vehicles.Length + 1);
                _vehicles[_vehicles.Length - 1] = vehicle;
            }
            else
            {
                Console.WriteLine("car limit ashilib");
            }
            if (vehicle is Truck)
            {
                if (_truck.Length < TruckLimit)
                {
                    Array.Resize(ref _truck, _truck.Length + 1);
                    _truck[_truck.Length - 1] = (Truck)vehicle;
                    Array.Resize(ref vehicles, _vehicles.Length + 1);
                    _vehicles[_vehicles.Length - 1] = vehicle;
                }
            }
            else
            {
                Console.WriteLine("truck limit ashilib");
            }

            
        }
        public void ShowAllVehicle()
        {
            foreach (var vehicle in vehicles)
            {
                if (vehicle is Car)
                {
                    Console.WriteLine($:"Car,Passenger Capasity: ")
                }
                else if (vehicle is Truck)
                {
                    Console.WriteLine($"")
                }
            }
        }
    }
}
            
