using System;

namespace FactoryPatternVehicle
{
    class Program
    { 
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of try to build a vehicle of your choice (ex.- 1, 2, 3, 4)");
            var answer = Console.ReadLine();
            var vehicle = VehicleFactory.GetVehicle(answer);
            vehicle.Drive();
        }
    }
}
