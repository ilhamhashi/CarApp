using System;
abstract public class Car : IDrivable
{
	public string Brand { get; set; }
	public string Model { get; set; }
	public string LicensePlate { get; set; }
	public int Odometer;
	public bool isEngineRunning;

    public Car(string brand, string model, string licensePlate)
	{
		Brand = brand;
		Model = model;
		LicensePlate = licensePlate;
		Odometer = 0;
		isEngineRunning = true;
	}

	public void StartEngine()
	{
		isEngineRunning = true;
		Console.WriteLine("Motoren er tændt.");
	}

	public void StopEngine()
	{
        isEngineRunning = false;
        Console.WriteLine("Motoren er slukket.");
    }
	public virtual void Drive(double distance)
	{
        Odometer += Convert.ToInt32(distance);
        //UseEnergy(distance);
        Console.WriteLine($"Bilen kører en tur på {distance} km.");
    }

	public virtual bool CanDrive(double distance)
	{
		return true;
	}

    public virtual string GetCarDetails()
    {
        return $"Brand: {Brand}\nModel: {Model}\nNummerplade: {LicensePlate}\nOdometer: {Odometer} km";
    }

}
