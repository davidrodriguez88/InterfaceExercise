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
        Console.WriteLine("Car is Driving");
    }
    
    public string Logo { get; set; }
    public string Name { get; set; }
}