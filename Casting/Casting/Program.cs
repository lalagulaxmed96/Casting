using Core.Models;
using System.Reflection;

namespace Casting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Truck truck = new Truck();
            Truck truck1 = new Truck();
            Truck truck2 = new Truck();
            
            Car car = new Car();
            Car car1 = new Car();
            Car car2 = new Car();
           


            RentCar rentCar = new RentCar();
            rentCar.CarLimit = 2;
            rentCar.TruckLimit = 2; 

            

            rentCar.AddVehicle(car);
            rentCar.AddVehicle(car1);
            rentCar.AddVehicle(car2);
          
            rentCar.AddVehicle(truck);
            rentCar.AddVehicle(truck1);
            rentCar.AddVehicle(truck2);




            rentCar = new RentCar();

            Car car1 = new Car
            {
                Marka = "Honda",
                Model = "Civic",
                Year = 2018,
                PassengerCapasity = 5
            };
            Car car2 = new Car
            {
                Marka = "Toyota",
                Model = "Camry",
                Year = 2019,
                PassengerCapasity = 5
            };

            Truck truck1 = new Truck
            {
                Marka = "Chevrolet",
                Model = "Silverado",
                Year = 2018,
                CarryingCapasity = 2600
            };
            Truck truck2 = new Truck
            {
                Marka = "Ford",
                Model = "F-150",
                Year = 2017,
                CarryingCapasity = 2400
            };
        }
    }
}
