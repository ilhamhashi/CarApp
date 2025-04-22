namespace CarApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Test FuelCar (Brand, Model, Licenseplate, TankCapacity, KmPerLiter)

            FuelCar fuelCar = new FuelCar("Toyota", "Corolla", "AB12345", 50, 20);

            fuelCar.StartEngine();

            fuelCar.Drive(100);

            Console.WriteLine($"FuelCar Odometer: {fuelCar.Odometer} km, Fuel left: {fuelCar.FuelLevel} liter");



            // Test ElectricCar

            ElectricCar electricCar = new ElectricCar("Tesla", "Model S", "CD67890", 100, 5);

            electricCar.StartEngine();

            electricCar.Drive(50);

            Console.WriteLine($"ElectricCar Odometer: {electricCar.Odometer}, Battery left: {electricCar.BatteryLevel}");
            
        }
    }
}
