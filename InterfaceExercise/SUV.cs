using System;

namespace InterfaceExercise;

public class SUV : IVehicle, ICompany
{
    public int NumberOfSeats { get; set; }
    public bool HasThirdRow { get; set; }
    
    public int NumberOfWheels { get; set; }
    public bool HasSeatBelts { get; set; }
    public bool HornWorks  { get; set; }
    public bool HasLicensePlate { get; set; }

    public void Drive()
    {
        Console.WriteLine("SUV is Driving");
    }
    
    public string Logo { get; set; }
    public string Name { get; set; }
    
    public void DisplayDetails()
    {
        Console.WriteLine($"--- {Name} SUV Details ---");
        Console.WriteLine($"Logo: {Logo}");
        Console.WriteLine($"Number of Wheels: {NumberOfWheels}");
        Console.WriteLine($"Has Seat Belts: {HasSeatBelts}");
        Console.WriteLine($"Horn Works: {HornWorks}");
        Console.WriteLine($"Has License Plate: {HasLicensePlate}");
        Console.WriteLine($"Number of Seats: {NumberOfSeats}");
        Console.WriteLine($"Has Third Row: {HasThirdRow}");
        Console.WriteLine();
    }
}