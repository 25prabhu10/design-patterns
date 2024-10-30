namespace DesignPatternsInCSharp.src.OopPrinciples.Polymorphism;

public class Aeroplane : Vehicle
{
    // Along with the properties of the Vehicle class, the Aeroplane class has additional properties such as NumberOfEngines and NumberOfWings.
    public int NumberOfEngines { get; set; }
    public int NumberOfWings { get; set; }

    // The Start method is overridden in the Aeroplane class.
    // How the aeroplane starts is different from how a car or bike starts.
    public override void Start()
    {
        Console.WriteLine("Starting the aeroplane");
    }

    // The Stop method is overridden in the Aeroplane class.
    public override void Stop()
    {
        Console.WriteLine("Stopping the aeroplane");
    }
}