using System;

namespace InterfaceExercise;

public class Truck : IVehicle, ICompany
{
    public bool HasTailgate { get; set; }
    public bool CanTow { get; set; }

    public int NumberOfWheels { get; set; }
    public bool HasSeatBelts { get; set; }
    public bool HornWorks { get; set; }
    public bool HasLicensePlate { get; set; }

    public void Drive()
    {
        Console.WriteLine("Car is Driving");
    }

    public string Logo { get; set; }
    public string Name { get; set; }
}