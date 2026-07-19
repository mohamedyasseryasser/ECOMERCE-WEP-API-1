using ECommerce.Domain.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerce.Domain.DTOs.orderdto
{
    public class orderresponsedto
    {
        public int Orderid { get; set; }
        public decimal TotalAmount { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
        public decimal? DiscountAmount { get; set; }
        public decimal? ShippingFee { get; set; }
        public decimal? TaxAmount { get; set; }
        public decimal FinalAmount { get; set; }
        public string PaymentMethod { get; set; }
        public string PaymentStatus { get; set; }
        public string statue { get; set; }
        public int? address_id { get; set; }
        public ICollection<suborderdto>? SubOrders { get; set; } = new List<suborderdto>();

        public int customer_id { get; set; }

        public int? CouponId { get; set; }

        public string? AffiliateCode { get; set; }
      
        public int? AffiliateId { get; set; }
    }
}
