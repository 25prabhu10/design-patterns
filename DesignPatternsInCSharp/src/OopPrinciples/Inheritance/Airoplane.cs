namespace DesignPatternsInCSharp.src.OopPrinciples.Inheritance;

public class Airoplane : Vehicle
{
    // Along with the properties of the Vehicle class, the Airoplane class has additional properties such as NumberOfEngines and NumberOfWings.
    public int NumberOfEngines { get; set; }
    public int NumberOfWings { get; set; }
}