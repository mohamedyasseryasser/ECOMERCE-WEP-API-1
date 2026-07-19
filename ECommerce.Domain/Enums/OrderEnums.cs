namespace ECommerce.Domain.Enums
{
    public enum PaymentStatus
    {
        Pending,
        Completed,
        Failed,
        Cancelled
    }

    public enum OrderStatus
    {
        Pending,
        Processing,
        Shipped,
        Delivered,
        Cancelled,
        Canceled
    }

    public enum SubOrderStatus
    {
        Pending,
        Processing,
        Shipped,
        Delivered,
        Cancelled,
        Canceled
    }

    public enum CouponType
    {
        Percentage,
        Fixed,
        FixedAmount
    }
}
