using FluentValidation;

namespace FluentValidationDemo.Models;

public class OrderValidator : AbstractValidator<Order>
{
    public OrderValidator()
    {
        RuleFor(order => order.UserId).NotEmpty().WithMessage("user id can't be empty");
        RuleFor(order => order.Quantity).NotEmpty().WithMessage("order cant be empty").GreaterThan(0).WithMessage("quantity must greater than 0");
        RuleFor(order => order.ProductNumber).NotEmpty().WithMessage("product number required");
    }
}
