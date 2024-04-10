using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public static class VehicleFactory
    {
        public static IVehicle GetVehicle(int tireCount)
        {
            //Switch statements evaluate, then executes all statements taht follow the matching CASE label, use the default keyword (line 22) to ensure that all values are returned properly
            switch (tireCount)
            {
                case 4:
                    return new Car();
                case 6:
                    return new Truck();
                case 2:
                    return new Motorcycle();
                default:
                    throw new ArgumentException("Not a valid amount of tires for a vehicle");
            }
        }
    }
}
