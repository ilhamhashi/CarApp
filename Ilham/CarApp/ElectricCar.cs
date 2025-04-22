using System;

internal class ElectricCar : Car
{

    public double BatteryLevel { get; set; }
	public double BatteryCapacity { get; set; }
	public double KmPerKWh {  get; set; }

    public ElectricCar(string brand, string model, string licensePlate, double batteryCapacity, double kmPerKWh) : base(brand, model, licensePlate)
    {
		BatteryCapacity = batteryCapacity;
		KmPerKWh = kmPerKWh;
    }

    public void Charge(double amount)
	{
	}

	public override void Drive(double distance) 
	{ 
		base.Drive(distance);
        double batteryConsumption = distance / KmPerKWh;
        BatteryLevel -= batteryConsumption;
        Console.WriteLine("Dette er en elbil!");
	}

}
