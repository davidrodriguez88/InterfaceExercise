namespace InterfaceExercise;

public interface IVehicle
{
    int NumberOfWheels { get; set; }
    
    bool HasSeatBelts { get; set; }
    bool HornWorks { get; set; }
    bool HasLicensePlate { get; set; }
    void Drive();
}