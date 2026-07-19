using ECommerce.Domain.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerce.Domain.Models
{
    public class Cart
    {
        [Key]
        public int Cartid {  get; set; }
        public cartstatue statue { get; set; } = cartstatue.Open;
        public DateTime? createdAt { get; set; }
        public decimal totalAmount {  get; set; }
        public DateTime? updatedAt { get; set; }
        [ForeignKey("customer")]
        public int? customer_id {  get; set; }
        public customer? customer { get; set; }
        public ICollection<CartItems>? CartItems { get; set; }=new List<CartItems>();
    }
}
