using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerce.Domain.Models
{
    public class WishList
    {
        public int WishlistId { get; set; }
        [ForeignKey("Customer")]
        public int CustomerId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public customer? Customer { get; set; }
        public virtual ICollection<WithItems>? WishlistItems { get; set; } = new List<WithItems>();
    }
}
