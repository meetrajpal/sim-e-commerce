namespace ECommerce.Domain.Entities.Orders;

public class UpiOrder : Order
{
    public override PaymentType PaymentType { get; } = PaymentType.UPI;
}
