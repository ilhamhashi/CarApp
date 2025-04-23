namespace CarApp
{
    public class Program
    {
        static void Main(string[] args)
        {

            CarAppSystem CarApp = new();
            CarApp.Kør();
            CarApp.DemoItems();

            //// Test FuelCar

            //fuelCar.Drive(100);

            //Console.WriteLine($"FuelCar Odometer: {fuelCar.Odometer}, Fuel left: {fuelCar.FuelLevel}");

            //fuelCar.Drive(10);

            //Console.WriteLine($"FuelCar Odometer: {fuelCar.Odometer}, Fuel left: {fuelCar.FuelLevel}");


            //// Test ElectricCar

            //ElectricCar electricCar = new ElectricCar("Tesla", "Model S", "CD67890", 100, 5);

            //electricCar.StartEngine();

            //electricCar.Drive(50);

            //Console.WriteLine($"ElectricCar Odometer: {electricCar.Odometer}, Battery left: {electricCar.BatteryLevel}");

            //electricCar.Drive(5);

            //Console.WriteLine($"ElectricCar Odometer: {electricCar.Odometer}, Battery left: {electricCar.BatteryLevel}");


            //// Test Taxi

            //Taxi taxi = new Taxi("Mercedes", "E-Class", "TX11223", 49.0, 12.3, 7.5);

            //taxi.StartEngine();

            //taxi.StartMeter();

            //taxi.Drive(20);

            //taxi.Drive(30);

            //taxi.Drive(50);

            //taxi.StopMeter();

            //double fare = taxi.CalculateFare(20, 30); // 20 km og 30 minutter

            //Console.WriteLine($"Taxi Odometer: {taxi.Odometer}, Fare: {fare} kr.");



            ////Test FuelCar (Brand, Model, Licenseplate, TankCapacity, KmPerLiter)

            //FuelCar fuelCar = new FuelCar("Toyota", "Corolla", "AB12345", 50, 20);

            //fuelCar.StartEngine();

            //fuelCar.Drive(100);

            //Console.WriteLine($"FuelCar Odometer: {fuelCar.Odometer} km, Fuel left: {fuelCar.FuelLevel} liter");



            //// Test ElectricCar

            //ElectricCar electricCar = new ElectricCar("Tesla", "Model S", "CD67890", 100, 5);

            //electricCar.StartEngine();

            //electricCar.Drive(50);

            //Console.WriteLine($"ElectricCar Odometer: {electricCar.Odometer}, Battery left: {electricCar.BatteryLevel}");

        }
    }
}
