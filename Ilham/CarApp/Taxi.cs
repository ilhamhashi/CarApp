using System;
using System.Runtime.ConstrainedExecution;

public class Taxi : Car, IEnergy
{
    public double StartPrice { get; set; }
    public double PricePerKm { get; set; }
    public double PricePerMinute { get; set; }
    private bool MeterStarted { get; set; }
    private Car Car { get; set; }
    public double EnergyLevel { get; }
    public double MaxEnergy { get; }

    public Taxi(string brand, string model, string licensePlate, Car car, double startPrice, double pricePerKm, double pricePerMinute) : base(brand, model, licensePlate)
    {
        Car = car;
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

    public void Refill(double amount)
    {

    }

    public void UseEnergy(double distance)
    {

    }

    public override void Drive(double distance)
    {
        base.Drive(distance);
    }

    public override bool CanDrive(double distance)
    {
        return base.CanDrive(distance);
    }

    public override string GetCarDetails()
    {
        return base.GetCarDetails();
    }

   
}




