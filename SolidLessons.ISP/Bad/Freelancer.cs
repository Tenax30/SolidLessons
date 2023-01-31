namespace SolidLessons.ISP.Bad;

public class Freelancer : IEmployee
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
        //look for order logic
    }

    public void SubmitReport()
    {
        throw new Exception("Freelancer must not submit order");
    }

    public void AttendMeeting()
    {
        throw new Exception("Freelancer must not attend meeting");
    }
}