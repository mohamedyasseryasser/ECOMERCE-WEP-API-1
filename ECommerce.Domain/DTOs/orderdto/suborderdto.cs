using ECommerce.Domain.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerce.Domain.DTOs.orderdto
{
    public class suborderdto
    {
        public int SubOrderId { get; set; }
        public decimal Subtotal { get; set; }
        public string Status { get; set; }
        public DateTime? StatusUpdatedAt { get; set; }
        public string TrackingNumber { get; set; }
        public string ShippingProvider { get; set; }
      
        public int seller_id { get; set; }
      
        public int OrderId { get; set; }
         public ICollection<orderitemsdto> Items { get; set; } = new List<orderitemsdto>();
    }
}
