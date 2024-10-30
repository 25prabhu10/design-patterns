namespace DesignPatternsInCSharp.src.CSharpConcepts;

class BaseMH
{
    public void Method() => Console.WriteLine($"obj of {GetType().Name,-12} runs Base.Method");
}

class Proxy : BaseMH
{
    public new void Method() => Console.WriteLine($"obj of {GetType().Name,-12} runs Proxy.Method");
}

interface IAmTheSavior
{
    void Method();
}

class BaseMH2 : IAmTheSavior
{
    public void Method() => Console.WriteLine($"obj of {GetType().Name,-12} runs Base.Method");
}

class Proxy2 : BaseMH2
{
    public new void Method() => Console.WriteLine($"obj of {GetType().Name,-12} runs Proxy.Method");
}

class MayBePProxy : BaseMH2, IAmTheSavior
{
    public void Method() => Console.WriteLine($"obj of {GetType().Name,-12} runs MayBePProxy.Method");
}

class TrueProxy : IAmTheSavior
{
    public void Method() => Console.WriteLine($"obj of {GetType().Name,-12} runs TrueProxy.Method");
}

public static class MethodHiding
{
    public static void Run()
    {
        BaseMH a = new BaseMH();
        BaseMH b = new Proxy();
        Proxy c = new Proxy();

        Console.WriteLine("Method hiding");
        a.Method(); // obj of BaseMH       runs Base.Method
        b.Method(); // obj of Proxy        runs Base.Method   (object reference type determines which method is called not the object type)
        c.Method(); // obj of Proxy        runs Proxy.Method

        // using `new` keyword to hide the base method
        Console.WriteLine("\nMethod hiding using `new` keyword");
        a.Method(); // obj of BaseMH       runs Base.Method
        b.Method(); // obj of Proxy        runs Base.Method  (object reference type determines which method is called not the object type)
        c.Method(); // obj of Proxy        runs Proxy.Method

        // this is not polymorphism
        // Avoid method hiding as it can lead to confusion
        // Use a different method name instead

        // Interface method hiding
        IAmTheSavior d = new BaseMH2();
        IAmTheSavior e = new Proxy2();
        IAmTheSavior f = new MayBePProxy();

        // Runtime is looking for interface in the class
        Console.WriteLine("\nInterface method hiding");
        d.Method();
        // d --> IAmTheSavior in BaseMH2 --> BaseMH2 actually implements IAmTheSavior --> BaseMH2.Method
        // obj of BaseMH2      runs Base.Method
        e.Method();
        // e --> IAmTheSavior in Proxy2 --> BaseMH2 actually implements IAmTheSavior --> BaseMH2.Method
        // obj of Proxy2       runs Base.Method

        // The above problem can be solved by inheriting the interface in the derived class along with the base class
        f.Method();
        // f --> IAmTheSavior in MayBePProxy --> MayBePProxy has implementation for IAmTheSavior --> MayBePProxy.Method
        // obj of MayBePProxy  runs MayBePProxy.Method

        // Why inherit from both class and interface?
        // Just implementing the interface, it achieves the same result and less confusion
        IAmTheSavior g = new TrueProxy();
        g.Method();
        // g --> IAmTheSavior in TrueProxy --> TrueProxy has implementation for IAmTheSavior --> TrueProxy.Method
        // obj of TrueProxy    runs TrueProxy.Method
    }
}