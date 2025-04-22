using System;

internal class Car
{
	public string Brand { get; set; }
	public string Model { get; set; }
	public string LicensePlate { get; set; }
	public int Odometer;
	public bool isEngineOn;

	public Car(string brand, string model, string licensePlate)
	{
		Brand = brand;
		Model = model;
		LicensePlate = licensePlate;
		Odometer = 0;
		isEngineOn = false;
	}

	public void StartEngine()
	{
		isEngineOn = true;
		Console.WriteLine("Motoren er tændt.");
	}

	public void StopEngine()
	{
        isEngineOn = false;
        Console.WriteLine("Motoren er slukket.");
    }

	public virtual void Drive(double distance)
	{
		int odometer = Odometer += Convert.ToInt32(distance);
		Console.WriteLine($"Bilen kører en tur på {distance} km.");
	}
}
