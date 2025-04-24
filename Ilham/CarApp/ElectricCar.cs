using System;

public class ElectricCar : Car, IEnergy
{

    public double BatteryLevel { get; set; }
	public double BatteryCapacity { get; set; }
	public double KmPerKWh {  get; set; }
    public double EnergyLevel { get; }
    public double MaxEnergy { get; }

    public ElectricCar(string brand, string model, string licensePlate, double batteryCapacity, double kmPerKWh) : base(brand, model, licensePlate)
    {
		BatteryCapacity = batteryCapacity;
		KmPerKWh = kmPerKWh;
    }

    public void Refill(double amount)
	{
        BatteryLevel += amount;
        Console.WriteLine($"Nyt batteriniveau: {BatteryLevel} KWh.");
    }
    public void UseEnergy(double distance)
    {
        BatteryLevel -= distance / KmPerKWh;
    }

    /* public override bool CanDrive()
    {
        if (BatteryLevel > 0 && isEngineOn)
            return true;
        else
            return false;
    }

    public override void Drive(double distance)
    {
        base.Drive(distance);
        Console.WriteLine("Dette er en elbil!");
    } */

    static public ElectricCar AddACar()
    {
        Console.Write("Indtast brand: ");
        string brand = Console.ReadLine();
        Console.Write("Indtast model: ");
        string model = Console.ReadLine();
        Console.Write("Indtast nummerplade: ");
        string licensePlate = Console.ReadLine();
        Console.Write("Indtast nuværende kilometerstand: ");
        int odometer = Convert.ToInt32(Console.ReadLine());
        Console.Write("Indtast batterikapacitet: ");
        double batteryCapacity = Convert.ToDouble(Console.ReadLine());
        Console.Write("Indtast nuværende batteriniveau: ");
        double batteryLevel = Convert.ToDouble(Console.ReadLine());
        Console.Write("Indtast km/KWh: ");
        double kmPerKWh = Convert.ToDouble(Console.ReadLine());

        ElectricCar electricCar = new(brand, model, licensePlate, batteryCapacity, kmPerKWh);
        electricCar.Odometer = odometer;
        electricCar.BatteryLevel = batteryLevel;

        Console.WriteLine($"Bilen {electricCar.Brand} {electricCar.Model} er oprettet!\n");
        return electricCar;
    }
    public override string GetCarDetails()
    {
        return base.GetCarDetails() + $"\nBatteriniveau: {BatteryLevel}\nBatterikapacitet: {BatteryCapacity}\nKm/KWh: {KmPerKWh}";
    }
}
