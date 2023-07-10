using System.Runtime.InteropServices;

namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {

            //for the first Vehicle
            Console.WriteLine();
            Console.WriteLine("What type of vehicle do you want a Truck or a car"); 
            string userInput = Console.ReadLine();
            //var tempVehicle = VehicleFactory.GetVehicle("honda");
            var tempVehicle = VehicleFactory.GetVehicle(userInput); //call your method in your factory class
            tempVehicle.Drive();

            //for the second Vehicle
            Console.WriteLine();
            Console.WriteLine("Let's Make another car or truck");
            string userInput2 = Console.ReadLine();
            var tempVehicle2 = VehicleFactory.GetVehicle(userInput2);
            tempVehicle2.Drive();
            

        }
    }
}
