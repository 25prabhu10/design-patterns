namespace DesignPatternsInCSharp.src.OopPrinciples.Coupling;

public class SmsSender : INotificationService
{
    public void SendNotification(string message)
    {
        Console.WriteLine($"Sending SMS: {message}");
    }
}