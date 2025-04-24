using System;

public interface IEnergy
{
	double EnergyLevel { get; }
	double MaxEnergy { get; }

	void Refill(double amount);
	void UseEnergy(double distance);
}
