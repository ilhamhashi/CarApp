using System;

public class FuelCar : Car
{
    public double FuelLevel { get; set; }
	public double TankCapacity { get; set; }
	public double KmPerLiter { get; set; }

    public FuelCar(string brand, string model, string licensePlate, double tankCapacity, double kmPerLiter) : base(brand, model, licensePlate)
    {
		TankCapacity = tankCapacity;
		KmPerLiter = kmPerLiter;
		FuelLevel = 0;
    }

    public override void RefuelOrCharge(double amount)
	{
        FuelLevel += amount;
        Console.WriteLine($"Nyt brændstofniveau: {FuelLevel} L.");
	}

    public override bool CanDrive()
    {
        if (FuelLevel >0 && isEngineOn)
            return true;
        else
        {
            return false;
        }
    }

    public override void UpdateEnergyLevel(double distance)
    {
        FuelLevel -= CalculateConsumption(distance);
    }

    public override double CalculateConsumption(double distance)
    {
        return distance / KmPerLiter;
    }

    public override void Drive(double distance)
    {
            base.Drive(distance);
    }

    static public Car AddACar()
    {
        Console.Write("Indtast brand: ");
        string brand = Console.ReadLine();
        Console.Write("Indtast model: ");
        string model = Console.ReadLine();
        Console.Write("Indtast nummerplade: ");
        string licensePlate = Console.ReadLine();
        Console.Write("Indtast nuværende kilometerstand: ");
        int odometer = Convert.ToInt32(Console.ReadLine());
        Console.Write("Indtast kapaciteten på brændstoftanken: ");
        double tankCapacity = Convert.ToDouble(Console.ReadLine());
        Console.Write("Indtast nuværende brændstofniveau: ");
        double fuelLevel = Convert.ToDouble(Console.ReadLine());

        Console.Write("Indtast km/L: ");
        double kmPerLiter = Convert.ToDouble(Console.ReadLine());

        FuelCar fuelCar = new(brand, model, licensePlate, tankCapacity, kmPerLiter);
        fuelCar.Odometer = odometer;
        fuelCar.FuelLevel = fuelLevel;

        Console.WriteLine($"Bilen {fuelCar.Brand} {fuelCar.Model} er oprettet!\n");
        return fuelCar;
    }

    public override string GetCarDetails()
    {
        return base.GetCarDetails() + $"\nBrændstofniveau: {FuelLevel}\nKapacitet på Brændstoftank: {TankCapacity}\nKm/L: {KmPerLiter}";
    }

    //public int SelectCar()
    //{
    //    if (cars.Count == 0)
    //    {
    //        Console.WriteLine("Ingen biler tilgængelige. Tilføj en bil først.");
    //        return -1;
    //    }

    //    int carIndex = -1;
    //    bool gyldigtValg = false;

    //    while (!gyldigtValg)
    //    {
    //        Console.WriteLine("Vælg en bil:");
    //        for (int i = 0; i < cars.Count; i++)
    //        {
    //            var car = cars[i];
    //            Console.WriteLine($"{i + 1}. {car.Brand}, {car.Model}, {car.LicensePlate}, {car.Odometer}");
    //        }
    //        Console.Write("Indtast nummer på bil: ");
    //        if (int.TryParse(Console.ReadLine(), out int valg) &&
    //            valg > 0 && valg <= cars.Count)
    //        {
    //            carIndex = valg - 1;
    //            gyldigtValg = true;
    //        }
    //        else
    //        {
    //            Console.WriteLine("Ugyldigt valg. Prøv igen.");
    //        }
    //    }
    //    return carIndex;
    //}
}
