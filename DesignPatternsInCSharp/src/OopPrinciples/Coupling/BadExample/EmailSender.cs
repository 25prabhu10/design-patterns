namespace DesignPatternsInCSharp.src.OopPrinciples.Coupling.BadExample;

public class EmailSender
{
    public void SendEmail(string message)
    {
        // Email sending logic
        Console.WriteLine("Sending email: " + message);
    }
}