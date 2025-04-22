using System;

internal class FuelCar : Car
{
    public double FuelLevel { get; set; }
	public double TankCapacity { get; set; }
	public double KmPerLiter { get; set; }

    public FuelCar(string brand, string model, string licensePlate, double tankCapacity, double kmPerLiter) : base(brand, model, licensePlate)
    {
		TankCapacity = tankCapacity;
		KmPerLiter = kmPerLiter;
		FuelLevel = tankCapacity;
    }

    public void Refuel(double amount)
	{
	}

	public override void Drive(double distance)
	{
		base.Drive(distance);
		double fuelConsumption = distance / KmPerLiter; 
		FuelLevel -= fuelConsumption;
		Console.WriteLine("Dette er en benzinbil!");
	}

}
