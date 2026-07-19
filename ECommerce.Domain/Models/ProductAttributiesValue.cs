using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerce.Domain.Models
{
    public class ProductAttributiesValue
    {
        [Key]
        public int ProductAttrValueId { get; set; }
        [ForeignKey("Product")]
        public int ProductId { get; set; }
        [ForeignKey("Attribute")]
        public int AttributeId { get; set; }
        public string Value { get; set; }
        public ProductAttributies Attribute { get; set; }
        public  product Product { get; set; }
    }
}
