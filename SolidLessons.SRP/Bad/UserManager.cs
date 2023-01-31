namespace SolidLessons.SRP;

public class UserManager
{
    public bool Authenticate(string username, string password)
    {
        // authentication logic
        return true;
    }
 
    public bool Authorize(string username, string role)
    {
        // authorization logic
        return true;
    }

    public User GetUserFromStorage(Guid id)
    {
        // getting user logic
        return new User();
    }

    public void AddUserToStorage(User user)
    {
        // adding user logic
    }
}
