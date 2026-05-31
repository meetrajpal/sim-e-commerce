namespace ECommerce.Domain.Entities.Orders;

public class NetBankingOrder : Order
{
    public override PaymentType PaymentType { get; } = PaymentType.NetBanking;
}
