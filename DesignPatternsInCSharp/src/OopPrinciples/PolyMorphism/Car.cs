namespace DesignPatternsInCSharp.src.OopPrinciples.Polymorphism;

public class Car : Vehicle
{
    // Along with the properties of the Vehicle class, the Car class has additional properties such as NumberOfDoors and NumberOfWheels.
    public int NumberOfDoors { get; set; }
    public int NumberOfWheels { get; set; }

    // The Start method is overridden in the Car class.
    public override void Start()
    {
        Console.WriteLine("Starting the car");
    }

    // The Stop method is overridden in the Car class.
    public override void Stop()
    {
        Console.WriteLine("Stopping the car");
    }
}