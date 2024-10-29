namespace DesignPatternsInCSharp.src.CSharpConcepts;

class OldVehicle
{
  public string Make { get; set; }
  public string Model { get; set; }
  public string EngineStatus { get; private set; } = "Off";

  public OldVehicle(string make, string model) => (Make, Model) = (make, model);

  public virtual void StartEngine()
  {
    // Derived class want to do something before starting the engine.
    EngineStatus = "Idle";
    // Derived class want to do something after starting the engine.
  }
}

class OldCar : OldVehicle
{
  public string ScreenContent { get; private set; } = "Off";

  public OldCar(string make, string model) : base(make, model) { }

  public override void StartEngine()
  {
    base.StartEngine(); // Call the base class method, else the EngineStatus will not be updated.
    // This leads to bug, if the derived class want to do something before or after the base class method.
    ScreenContent = "BasicInfo";
  }
}


abstract class Vehicle
{
  public string Make { get; set; }
  public string Model { get; set; }
  public string EngineStatus { get; private set; } = "Off";

  protected Vehicle(string make, string model) => (Make, Model) = (make, model);

  public void StartEngine()
  {
    if (EngineStatus != "Off") return;
    BeforeStartEngine();
    EngineStatus = "Idle";
    AfterStartEngine();
  }

  // This means all derived class must implement this method.
  protected abstract void BeforeStartEngine();
  protected abstract void AfterStartEngine();

  public void StopEngine()
  {
    BeforeStopEngine();
    EngineStatus = "Off";
    AfterStopEngine();
  }

  // Using virtual keyword, derived class can override only if they want to.
  protected virtual void BeforeStopEngine() { }
  protected virtual void AfterStopEngine() { }
}

class Car : Vehicle
{
  public string ScreenContent { get; private set; } = "Off";

  public Car(string make, string model) : base(make, model) { }

  // Empty implementation, as it is not required.
  protected override void BeforeStartEngine() { }

  protected override void AfterStartEngine()
  {
    // Derived class want to do something after starting the engine.
    ScreenContent = "BasicInfo";
  }

  protected override void BeforeStopEngine()
  {
    // Derived class want to do something before stopping the engine.
    Console.WriteLine("Turn of AC and Headlights.");
  }

  // No need to implement AfterStopEngine, as it is not required.
}

public static class AbstractMethod
{
  public static void Run()
  {
    OldCar oldCar = new OldCar("Toyota", "Corolla");
    oldCar.StartEngine();
    Console.WriteLine($"OldCar: {oldCar.EngineStatus}, {oldCar.ScreenContent}");

    Car car = new Car("Toyota", "Corolla");
    car.StartEngine();
    Console.WriteLine($"Car: {car.EngineStatus}, {car.ScreenContent}");
  }
}
