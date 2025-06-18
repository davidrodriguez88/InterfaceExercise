using System;

namespace InterfaceExercise;

public interface IVehicle : ICompany
{
    int NumberOfWheels { get; set; }
    
    bool HasSeatBelts { get; set; }
    bool HornWorks { get; set; }
    bool HasLicensePlate { get; set; }
    
    void Drive();
    void DisplayDetails();
}