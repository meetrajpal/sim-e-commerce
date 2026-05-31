namespace ECommerce.Domain.Entities.Orders;

public class CodOrder : Order
{
    public override PaymentType PaymentType { get; } = PaymentType.CashOnDelievery;
}
