namespace DesignPatternsInCSharp.src.OopPrinciples.Coupling;

public class OrderPlace
{
    private readonly INotificationService _notificationService;

    public OrderPlace(INotificationService notificationService)
    {
        _notificationService = notificationService;
    }

    public void PlaceOrder()
    {
        // Order placing logic

        // OrderPlace is tightly coupled with EmailSender
        // If we want to change the email sending logic, we have to change the OrderPlace class
        // This is a bad practice
        _notificationService.SendNotification("Your order has been placed successfully");
    }
}