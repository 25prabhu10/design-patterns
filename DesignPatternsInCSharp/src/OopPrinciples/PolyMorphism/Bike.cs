namespace DesignPatternsInCSharp.src.OopPrinciples.Polymorphism;

public class Bike : Vehicle
{
    // Along with the properties of the Vehicle class, the Bike class has additional properties such as NumberOfWheels.
    // As it dose not have doors like a car.
    public int NumberOfWheels { get; set; }

    // The Start method is overridden in the Bike class.
    public override void Start()
    {
        Console.WriteLine("Starting the bike");
    }

    // The Stop method is overridden in the Bike class.
    public override void Stop()
    {
        Console.WriteLine("Stopping the bike");
    }
}