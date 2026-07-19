using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerce.Domain.Models
{
    public class ProductImage
    {
        [Key]
        public int ImageId { get; set; }
        [ForeignKey("Product")]
        public int ProductId { get; set; }

        public string ImageUrl { get; set; }

        public int? DisplayOrder { get; set; }

        public product Product { get; set; }
    }
}
