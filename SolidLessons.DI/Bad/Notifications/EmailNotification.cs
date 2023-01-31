namespace SolidLessons.DI.Bad.Notifications;

public class EmailNotification
{
    public string EmailAddress { get; set; }

    public void Send(string message)
    {
        // send an email notification logic
    }
}