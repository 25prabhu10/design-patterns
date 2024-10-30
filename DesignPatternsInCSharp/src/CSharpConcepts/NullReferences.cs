// using LanguageExt;

namespace DesignPatternsInCSharp.src.CSharpConcepts;

public class NullReferences
{
    record Person(string FirstName, string LastName)
    {
        public override string ToString() => $"{FirstName} {LastName}";
    }

    record Celebrity(string FirstName, string LastName, string KnownFor) : Person(FirstName, LastName)
    {
        public override string ToString() => $"{base.ToString()} known for ({KnownFor})";
    }

    public static void Run()
    {
        Person? left = null;
        Person? bob = new Person("Pat", "Smith");
        Person fowler = new Celebrity("Martin", "Fowler", "Software Architecture");
        Person martin = new Celebrity("Bob", "Martin", "Agile");

        ShowCase<Person?>("Nullable reference types", Console.WriteLine, left, bob, fowler, martin);
        ShowCase<Person>("Non-nullable reference types", Console.WriteLine, bob, fowler, martin);
        ShowCase("is null and is not null", IsNull, left, bob, fowler, martin);
        ShowCase("Type test and set", TypeTestAndSet, left, bob, fowler, martin);
        ShowCase("Property patterns", PropertyPatterns, left, bob, fowler, martin);
        ShowCase("Null propagation and coalescing", NullPropagationAndCoalescing, left, bob, fowler, martin);

        // Optional objects are never null
        /*Option<Person>[] maybePersons =*/
        /*{*/
        /*    Option<Person>.None,*/
        /*    Option<Person>.Some(bob),*/
        /*    Option<Person>.Some(fowler),*/
        /*    Option<Person>.Some(martin)*/
        /*};*/
        /*ShowCase("Optional objects", Optional, maybePersons);*/
    }

    /*static void Optional(Optional<Person> maybePerson)*/
    /*{*/
    /*    string report = maybePerson.Match(*/
    /*        None: () => string.Empty,*/
    /*        Some: person => person.ToString());*/
    /**/
    /*    maybePerson.Do(Console.WriteLine);*/
    /*}*/

    static void NullPropagationAndCoalescing(Person? person)
    {
        string report = person?.ToString() ?? string.Empty;

        if (!string.IsNullOrEmpty(report))
            Console.WriteLine(report);
    }

    static void PropertyPatterns(Person? person)
    {
        if (person is Celebrity { KnownFor: "Software Architecture" } celeb)
            Console.WriteLine($"{celeb.FirstName} is a celebrity known for {celeb.KnownFor}.");

        if (person is { FirstName: "Bob" })
            Console.WriteLine("Bob is a common person.");
        else
            Console.WriteLine("Not Bob.");
    }

    static void TypeTestAndSet(Person? person)
    {
        string report = person switch
        {
            Celebrity celebrity => $"{celebrity.FirstName} is a celebrity known for {celebrity.KnownFor}.",
            Person commonPerson => $"{commonPerson.FirstName} is a common person.",
            _ => string.Empty
        };
        if (!string.IsNullOrEmpty(report))
            Console.WriteLine(report);

        if (person is Celebrity) Console.WriteLine("*** Did you see a celebrity?");
    }

    static void IsNull(Person? person)
    {
        if (person is null)
            Console.WriteLine($"Person is null: {person} (null)");

        if (person is not null)
            Console.WriteLine($"Person is not null: {person}");
    }

    static void ShowCase<T>(string caption, Action<T> action, params T[] objects)
    {
        Console.WriteLine($"Showcasing {caption}:".ToUpper());
        foreach (T obj in objects) action(obj);
        Console.WriteLine();
    }
}