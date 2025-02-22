using FluentValidation;
using FluentValidationDemo.Repository;

namespace FluentValidationDemo.Models;

public class UserValidator: AbstractValidator<User>
{
    private readonly IUserRepository _userRepository;
    public UserValidator(IUserRepository userRepository)
    {
        _userRepository = userRepository;
        RuleFor(user => user.UserName).NotEmpty().WithMessage("name is required");
        RuleFor(user => user.Email)
            .NotEmpty().WithMessage("email required")
            .EmailAddress().WithMessage("invalid email format")
            .Must(email => !_userRepository.IsEmailExist(email));
        RuleFor(user => user.Password).NotEmpty().WithMessage("password required").MinimumLength(8).WithMessage("min length is 8");
        RuleFor(user => user.Id).NotEmpty().WithMessage("guid can't be empty");
    }
}
