using System;

public class Trip
{
    public double Distance { get; private set; }
    public DateTime TripDate { get; private set; }
    public DateTime StartTime { get; private set; }
    public DateTime EndTime { get; private set; }

    public Trip(double distance, DateTime tripDate, DateTime startTime, DateTime endTime)
	{
        Distance = distance;
        TripDate = tripDate;
        StartTime = startTime;
        EndTime = endTime;
	}

    static public Trip AddATrip()
    {
        Console.Write("Indtast distances for turen (km): ");
        double distance = Convert.ToDouble(Console.ReadLine());
        Console.Write("Indtast dato: ");
        DateTime tripDate = Convert.ToDateTime(Console.ReadLine());
        Console.Write("Indtast starttid: ");
        DateTime startTime = Convert.ToDateTime(Console.ReadLine());
        Console.Write("Indtast sluttid: ");
        DateTime endTime = Convert.ToDateTime(Console.ReadLine());

        Trip trip = new(distance, tripDate, startTime, endTime);
        Console.WriteLine("Turen er oprettet!\n");

        return trip;
    }

    public string GetTripDetails()
    {
        return $"Trip Date: {TripDate.ToShortDateString()}\nDistance: {Distance} km\n" +
               $"Start Time: {StartTime.ToShortTimeString()}\nEnd Time: {EndTime.ToShortTimeString()}\n";
    }

}
