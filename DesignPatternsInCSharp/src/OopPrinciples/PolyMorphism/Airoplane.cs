namespace DesignPatternsInCSharp.src.OopPrinciples.Polymorphism;

public class Airoplane : Vehicle
{
  // Along with the properties of the Vehicle class, the Airoplane class has additional properties such as NumberOfEngines and NumberOfWings.
  public int NumberOfEngines { get; set; }
  public int NumberOfWings { get; set; }

  // The Start method is overridden in the Airoplane class.
  // How the airoplane starts is different from how a car or bike starts.
  public override void Start()
  {
    Console.WriteLine("Starting the airoplane");
  }

  // The Stop method is overridden in the Airoplane class.
  public override void Stop()
  {
    Console.WriteLine("Stopping the airoplane");
  }
}
