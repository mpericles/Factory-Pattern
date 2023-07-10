using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public static class VehicleFactory
    {

        public static IVehicle GetVehicle(string carType)
        {
            switch (carType.ToLower())
            {
                case "car":
                    return new Car();
                case "honda":
                    return new Car();
                case "truck":
                    return new Truck();
                default:
                    return new Truck();
            }
        }


    }
}
