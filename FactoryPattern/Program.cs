namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            IVehicle Car1 = VehicleFactory.GetVehicle(4);
            Car1.Drive();

            IVehicle Truck1 = VehicleFactory.GetVehicle(6);
            Truck1.Drive();

            IVehicle Motorcycle1 = VehicleFactory.GetVehicle(2);
            Truck1.Drive();
        }
    }
}
