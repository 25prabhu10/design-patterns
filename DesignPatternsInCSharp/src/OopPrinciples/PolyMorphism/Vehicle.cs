namespace DesignPatternsInCSharp.src.OopPrinciples.Polymorphism;

public class Vehicle
{
  // These properties and methods are accessible from the derived classes.
  // Common properties for all vehicles.
  public string Brand { get; set; }
  public string Model { get; set; }
  public int Year { get; set; }

  // These methods can be overridden by the derived classes.
  public virtual void Start()
  {
    Console.WriteLine("Starting the vehicle");
  }

  public virtual void Stop()
  {
    Console.WriteLine("Stopping the vehicle");
  }
}
