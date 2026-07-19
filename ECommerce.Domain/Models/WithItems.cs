using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerce.Domain.Models
{
    public class WithItems
    {
        [Key]
        public int WishlistItemId { get; set; }
        [ForeignKey("Wishlist")]
        public int WishlistId { get; set; }
        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public DateTime? AddedAt { get; set; }
        public product? Product { get; set; }
        public WishList? Wishlist { get; set; }
    }
}
