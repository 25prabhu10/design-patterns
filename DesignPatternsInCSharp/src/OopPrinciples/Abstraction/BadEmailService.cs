namespace DesignPatternsInCSharp.src.OopPrinciples.Abstraction;

public class BadEmailService
{
  public void SendEmail()
  {
    Console.WriteLine("Sending email...");
  }

  public void Connect()
  {
    Console.WriteLine("Connecting to email server...");
  }

  public void Authenticate()
  {
    Console.WriteLine("Authenticating...");
  }

  public void Disconnect()
  {
    Console.WriteLine("Disconnecting...");
  }
}