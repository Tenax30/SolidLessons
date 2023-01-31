namespace SolidLessons.ISP.Bad;

public class OfficeEmployee : IEmployee
{
    public void StartWork()
    {
        //start work logic
    }

    public void EndWork()
    {
        //end work logic
    }

    public void TakeBreak()
    {
        //take break logic
    }

    public void LookForOrder()
    {
        throw new Exception("Office employee must not look for order");
    }

    public void SubmitReport()
    {
        //submit report logic
    }

    public void AttendMeeting()
    {
       //attend meeting logic
    }
}