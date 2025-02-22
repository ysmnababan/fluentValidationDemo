namespace FluentValidationDemo.Repository;

public interface IUserRepository
{
    bool IsEmailExist(string email);
}
