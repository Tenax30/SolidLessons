using SolidLessons.DI.Bad.Enums;
using SolidLessons.DI.Bad.Notifications;

namespace SolidLessons.DI.Bad;

public class OrderProcessor
{
    private readonly SMSNotification _smsNotification;
    private readonly EmailNotification _emailNotification;

    private readonly IDictionary<Guid, Order> _orders;

    public OrderProcessor()
    {
        _smsNotification = new SMSNotification();
        _emailNotification = new EmailNotification();
        _orders = new Dictionary<Guid, Order>();
    }

    public void AddOrder(Order order, NotificationType notificationType)
    {
        _orders[order.Id] = order;
        SendNotification(notificationType, $"Order {order.Id} was added to processing");
    }

    public void CompleteOrder(Guid orderId, NotificationType notificationType)
    {
        _orders[orderId].Completed = true;
        _orders.Remove(orderId);
        SendNotification(notificationType, $"Order {orderId} is completed");
    }

    private void SendNotification(NotificationType notificationType, string message)
    {
        switch (notificationType)
        {
            case NotificationType.Email:
                _emailNotification.Send(message);
                break;
            case NotificationType.Sms:
                _smsNotification.Send(message);
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(notificationType), notificationType, null);
        }
    }
}