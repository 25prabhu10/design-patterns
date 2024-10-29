namespace DesignPatternsInCSharp.src.OopPrinciples.Inheritance;

public class Vehicle
{
  // These properties and methods are accessible from the derived classes.
  // Common properties for all vehicles.
  public string Brand { get; set; }
  public string Model { get; set; }
  public int Year { get; set; }

  // Common methods for all vehicles.
  public void Start()
  {
    Console.WriteLine("Starting the vehicle");
  }

  public void Stop()
  {
    Console.WriteLine("Stopping the vehicle");
  }
}
