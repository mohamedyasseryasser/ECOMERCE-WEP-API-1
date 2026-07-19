using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerce.Domain.Models
{
    public class productview
    {
        [Key]
        public int ProductViewid {  get; set; }
        [ForeignKey("Product")]
        public int ProductId { get; set; }
        [ForeignKey("Customer")]
        public int? CustomerId { get; set; }
        public string SessionId { get; set; }
        public DateTime? ViewedAt { get; set; }
        public customer? Customer { get; set; }
        public product? Product { get; set; }
    }
}
