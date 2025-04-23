using System;
abstract public class Car
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
		isEngineOn = true;
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
        Odometer += Convert.ToInt32(distance);
        UpdateEnergyLevel(distance);
        Console.WriteLine($"Bilen kører en tur på {distance} km.");
    }

    public virtual string GetCarDetails()
    {
        return $"Brand: {Brand}\nModel: {Model}\nNummerplade: {LicensePlate}\nOdometer: {Odometer} km";
    }

    public abstract bool CanDrive();
	public abstract void UpdateEnergyLevel(double distance);
	public abstract double CalculateConsumption(double distance);
	public abstract void RefuelOrCharge(double amount);
}
