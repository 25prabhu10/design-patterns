namespace DesignPatternsInCSharp.src.OopPrinciples.Coupling.BadExample;

public class OrderPlace
{
    public void PlaceOrder()
    {
        // Order placing logic

        // OrderPlace is tightly coupled with EmailSender
        // If we want to change the email sending logic, we have to change the OrderPlace class
        // This is a bad practice
        EmailSender emailSender = new EmailSender();
        emailSender.SendEmail("Your order has been placed successfully");
    }
}