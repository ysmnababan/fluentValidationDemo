
namespace FluentValidationDemo.Repository;

public class UserRepository : IUserRepository
{
    public bool IsEmailExist(string email)
    {
        //await Task.Delay(10);  // Simulates a delay (e.g., like waiting for a database call)
        return true;
    }
}
