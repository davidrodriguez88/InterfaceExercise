using System;

namespace InterfaceExercise;

public class Car : IVehicle, ICompany
{
    public bool HasTrunk { get; set; }
    public bool IsSedan { get; set; }
    
    public int NumberOfWheels { get; set; }
    public bool HasSeatBelts { get; set; }
    public bool HornWorks  { get; set; }
    public bool HasLicensePlate { get; set; }

    public void Drive()
    {
        Console.WriteLine("Car is Driving");
    }
    
    public string Logo { get; set; }
    public string Name { get; set; }
}