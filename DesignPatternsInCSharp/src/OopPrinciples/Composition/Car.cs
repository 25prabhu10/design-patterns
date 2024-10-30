namespace DesignPatternsInCSharp.src.OopPrinciples.Composition;

public class Car
{
    private readonly Engine _engine = new Engine();
    private readonly Wheels _wheels = new Wheels();
    private readonly Seats _seats = new Seats();
    private readonly Chassis _chassis = new Chassis();

    public void Drive()
    {
        _engine.Start();
        _wheels.Rotate();
        _chassis.Support();
        _seats.Sit();
        Console.WriteLine("Driving the car");
    }
}