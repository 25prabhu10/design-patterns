namespace DesignPatternsInCSharp.src.OopPrinciples.Inheritance;

public class Car : Vehicle
{
  // Along with the properties of the Vehicle class, the Car class has additional properties such as NumberOfDoors and NumberOfWheels.
  public int NumberOfDoors { get; set; }
  public int NumberOfWheels { get; set; }
}
