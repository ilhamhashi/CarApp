using System;

public class CarAppSystem
{
    private List<Car> cars = new();
    private List<Trip> trips = new();

    public void DemoItems()
    {
        FuelCar car1 = new FuelCar("Toyota", "Corolla", "BK79492", 40, 18);
        cars.Add(car1);
        FuelCar car2 = new FuelCar("Mercedes-Benz", "E-200", "KD29072", 50, 14);
        cars.Add(car2);
        ElectricCar car3 = new ElectricCar("Tesla", "Model S", "LW201983", 100, 87);
        cars.Add(car3);
        Trip trip1 = new Trip(10, DateTime.Now, DateTime.Now, DateTime.Now);
        trips.Add(trip1);
        Trip trip2 = new Trip(50, DateTime.Now, DateTime.Now, DateTime.Now);
        trips.Add(trip2);

    }

    public void Kør()
    {
        DemoItems();
        HovedMenu();
    }

    private void HovedMenu()
    {
        string prompt = "--- Velkommen til CarApp System ---\nBrug piletasterne og Enter for at navigere.\n";
        string[] menuPunkter = { "Start", "Om CarApp System", "Afslut" };
        Menu hovedMenu = new(prompt, menuPunkter);
        int indexValgt = hovedMenu.Kør();

        switch (indexValgt)
        {
            case 0:
                StartMenu();
                break;
            case 1:
                //OmCarAppSystem();
                break;
            case 2:
                //AfslutCarAppSystem();
                break;
        }
    }

    //private void StartMenu()
    //{
    //    string prompt = "--- CarApp System ---\n";
    //    string[] menuPunkter = { "Biler", "Ture", "Taxitjeneste", "Tilbage" };
    //    Menu startMenu = new(prompt, menuPunkter);
    //    int indexValgt = startMenu.Kør();

    //    switch (indexValgt)
    //    {
    //        case 0:
    //            BilMenu();
    //            break;
    //        case 1:
    //            TurMenu();
    //            break;
    //        case 2:
    //            TaxaMenu();
    //            break;
    //        case 3:
    //            HovedMenu();
    //            break;
    //    }
    //}

    private void StartMenu()
    {
        string prompt = "--- CarApp System ---\n";
        string[] menuPunkter = { "Tilføj en bil", "Tilføj en tur", "Start en tur", "Udskriv biloplysninger", "Udskriv turoplysninger","Tilbage" };
        Menu startMenu = new(prompt, menuPunkter);
        int indexValgt = startMenu.Kør();

        switch (indexValgt)
        {
            case 0:
                VælgBilType();
                break;
            case 1:
                trips.Add(Trip.AddATrip());
                Thread.Sleep(2000);
                StartMenu();
                break;
            case 2:
                int carIndex = SelectCar();
                Trip trip = trips[SelectTrip()];
                if (cars[carIndex].CanDrive())
                {
                    cars[carIndex].Drive(trip.Distance);
                    Thread.Sleep(2000);
                    StartMenu();
                }
                else
                {
                    Console.WriteLine("Du har ikke nok brændstof til turen. Indtast mængde du vil tanke/lade op (L eller KWh): ");
                    int amount = Convert.ToInt32(Console.ReadLine());
                    cars[carIndex].RefuelOrCharge(amount);
                    Thread.Sleep(2000);
                    StartMenu();
                }
                
                break;
            case 3:
                Console.WriteLine("\n" + cars[SelectCar()].GetCarDetails());
                Console.ReadKey();
                StartMenu();    
                break;
            case 4:
                Console.WriteLine("\n" + trips[SelectTrip()].GetTripDetails());
                Console.ReadKey();
                StartMenu();
                break;
            case 5:
                HovedMenu();
                break;
        }
    }

    private void VælgBilType()
    {
        string prompt = "--- Vælg biltype ---\n";
        string[] menuPunkter = { "Brændstofbil", "Elbil", "Taxa", "Tilbage" };
        Menu startMenu = new(prompt, menuPunkter);
        int indexValgt = startMenu.Kør();

        switch (indexValgt)
        {
            case 0:
                cars.Add(FuelCar.AddACar());
                Thread.Sleep(2000);
                StartMenu();
                break;
            case 1:
                cars.Add(ElectricCar.AddACar());
                Thread.Sleep(2000);
                StartMenu();
                break;
            case 2:
                //taxicars.Add(Taxi.AddACar());
                Thread.Sleep(2000);
                StartMenu();
                break;
            case 3:
                HovedMenu();
                break;
        }
    }

    public int SelectCar()
    {
        if (cars.Count == 0)
        {
            Console.WriteLine("Ingen biler tilgængelige. Tilføj en bil først.");
            Thread.Sleep(2000);
            StartMenu();
            return -1;
        }

        int carIndex = -1;
        bool gyldigtValg = false;

        while (!gyldigtValg)
        {
            Console.WriteLine("Vælg en bil:\n");
            Console.WriteLine(cars.Count);
            for (int i = 0; i < cars.Count; i++)
            {
                var car = cars[i];
                Console.WriteLine($"{i + 1}. {car.Brand}, {car.Model}, {car.LicensePlate}, {car.Odometer}");
            }
            Console.Write("\nIndtast nummer på bil: ");
            if (int.TryParse(Console.ReadLine(), out int valg) &&
                valg > 0 && valg <= cars.Count)
            {
                carIndex = valg - 1;
                gyldigtValg = true;
            }
            else
            {
                Console.WriteLine("Ugyldigt valg. Prøv igen.");
            }
        }
        return carIndex;
    }

    public int SelectTrip()
    {
        if (trips.Count == 0)
        {
            Console.WriteLine("Ingen ture tilgængelige. Tilføj en tur først.");
            Thread.Sleep(2000);
            StartMenu();
            return -1;
        }

        int tripIndex = -1;
        bool gyldigtValg = false;

        while (!gyldigtValg)
        {
            Console.WriteLine("Vælg en tur:\n");
            Console.WriteLine(trips.Count);
            for (int i = 0; i < trips.Count; i++)
            {
                var trip = trips[i];
                Console.WriteLine($"{i + 1}. {trip.Distance}, {trip.TripDate.ToShortDateString()}, {(trip.StartTime).ToShortTimeString()}, {(trip.EndTime).ToShortTimeString()}");
            }
            Console.Write("\nIndtast nummer på tur: ");
            if (int.TryParse(Console.ReadLine(), out int choice) &&
                choice > 0 && choice <= trips.Count)
            {
                tripIndex = choice - 1;
                gyldigtValg = true;
            }
            else
            {
                Console.WriteLine("Ugyldigt valg. Prøv igen.");
            }
        }
        return tripIndex;
    }


    /*private void BilMenu()
    {
        string prompt = "--- Tilføj en bil ---\n";
        string[] menuPunkter = { "Start", "Om CarApp System", "Afslut" };
        Menu hovedMenu = new Menu(prompt, menuPunkter);
        int indexValgt = hovedMenu.Kør();

        switch (indexValgt)
        {
            case 0:
                StartMenu();
                break;
            case 1:
                //OmCarAppSystem();
                break;
            case 2:
                //AfslutCarAppSystem();
                break;
        }
    }*/

}
