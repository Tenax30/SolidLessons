namespace SolidLessons.DI.Bad;

public class SMSNotification
{
    public string PhoneNumber { get; set; }

    public void Send(string message)
    {
        // send an SMS notification logic
    }
}