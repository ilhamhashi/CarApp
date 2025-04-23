using System;

public class Taxi : FuelCar
{
    public double StartPrice { get; set; }
    public double PricePerKm { get; set; }
    public double PricePerMinute { get; set; }
    public bool MeterStarted { get; set; }

    public Taxi(string brand, string model, string licensePlate, double tankCapacity, double kmPerLiter, double startPrice, double pricePerKm, double pricePerMinute) : base(brand, model, licensePlate, tankCapacity, kmPerLiter)
    {
        StartPrice = startPrice;
        PricePerKm = pricePerKm;
        PricePerMinute = pricePerMinute;
        MeterStarted = false;
    }

    public void StartMeter()
    {
        MeterStarted = true;
        Console.WriteLine("Din taxatur er startet!");
    }

    public void StopMeter()
    {
        MeterStarted = false;
        Console.WriteLine("Din taxatur er slut!");
    }

    public double CalculateFare(double distance, double minutes)
    {
        return StartPrice + PricePerKm * distance + PricePerMinute * minutes;
    }

    public override bool CanDrive()
    {
        return base.CanDrive();
    }

    public override void UpdateEnergyLevel(double distance)
    {
        base.UpdateEnergyLevel(distance);
    }

    public override double CalculateConsumption(double distance)
    {
        return base.CalculateConsumption(distance);
    }

    public override void Drive(double distance)
    {
        base.Drive(distance);
    }
}




