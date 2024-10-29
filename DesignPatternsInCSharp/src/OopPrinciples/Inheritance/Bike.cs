namespace DesignPatternsInCSharp.src.OopPrinciples.Inheritance;

public class Bike : Vehicle
{
  // Along with the properties of the Vehicle class, the Bike class has additional properties such as NumberOfWheels.
  // As it dose not have doors like a car.
  public int NumberOfWheels { get; set; }
}
