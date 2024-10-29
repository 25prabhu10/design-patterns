namespace DesignPatternsInCSharp.src.CSharpConcepts;

class Base
{
  // At runtime, the object has access to different references such as Type and vtable
  // Type: Base (always resolved from assigned type not reference)
  // vtable: BaseVtable
  //     [VirtA] --> Base.VirtA
  //     [VirtB] --> Base.VirtB
  public virtual void VirtA() => Console.WriteLine("Base.VirtA");
  public virtual void VirtB() => Console.WriteLine("Base.VirtB");
}

class Derived : Base
{
  // Type: Derived
  // vtable: DerivedVtable
  //     [VirtA] --> Derived.VirtA
  //     [VirtB] --> Base.VirtB
  public override void VirtA() => Console.WriteLine("Derived.VirtA");
}

public static class VirtualMethod
{
  public static void Run()
  {
    // Let us consider a base class with two virtual methods VirtA and VirtB.
    // The Derived class inherits from the Base class and overrides the VirtA method.
    // When an object of the Derived class is created, the overridden VirtA method is called.
    Base a = new Base(); // reference: Base, object: Base
    Base b = new Derived(); // reference: Base, object: Derived
    Derived c = new Derived(); // reference: Derived, object: Derived

    // Here we have three object references, at runtime, the actual object type is used to determine which method to call.
    a.VirtA();
    // a --> Base --> BaseVtable[VirtA] --> Base.VirtA
    // Output: Base.VirtA

    b.VirtA();
    // b --> Derived --> DerivedVtable[VirtA] --> Derived.VirtA
    // Output: Derived.VirtA

    c.VirtA();
    // c --> Derived --> DerivedVtable[VirtA] --> Derived.VirtA
    // Output: Derived.VirtA

    Console.WriteLine($"Type: {a.GetType().Name}"); // Type: Base
    Console.WriteLine($"Type: {b.GetType().Name}"); // Type: Derived
    Console.WriteLine($"Type: {c.GetType().Name}"); // Type: Derived

    // The object `b` has been assigned to reference `Base` but the actual object is of type `Derived`.
    // At runtime all objects of a type refer to the same vtable.
  }
}
