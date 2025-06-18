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
        Console.WriteLine("Truck is Driving");
    }

    public string Logo { get; set; }
    public string Name { get; set; }
    
    public void DisplayDetails()
    {
        Console.WriteLine($"--- {Name} Truck Details ---");
        Console.WriteLine($"Logo: {Logo}");
        Console.WriteLine($"Number of Wheels: {NumberOfWheels}");
        Console.WriteLine($"Has Seat Belts: {HasSeatBelts}");
        Console.WriteLine($"Horn Works: {HornWorks}");
        Console.WriteLine($"Has License Plate: {HasLicensePlate}");
        Console.WriteLine($"HasTailgate: {HasTailgate}");
        Console.WriteLine($"Can Tow: {CanTow}");
        Console.WriteLine();
    }
}