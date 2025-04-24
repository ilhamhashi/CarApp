using System;

public interface IDrivable
{
	void StartEngine();
	void StopEngine();
	void Drive(double distance);
	bool CanDrive(double distance);
}
