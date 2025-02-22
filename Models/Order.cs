namespace FluentValidationDemo.Models;

public class Order
{
    public int ProductNumber { get; set; }
    public int Quantity { get; set; }
    public Guid UserId { get; set; }
}
