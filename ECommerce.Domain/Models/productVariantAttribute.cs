using System.ComponentModel.DataAnnotations;

namespace ECommerce.Domain.Models
{
    public class productVariantAttribute
    {
        [Key]
        public int ProductVariantAttrid {  get; set; }
        public string possiblevalue { get; set; }
        public string AttributeName { get; set; }
        public string AttributeValue {  get; set; }
        public int? variatn_id {  get; set; }
        public productVariant? productVariant { get; set; }
    }
}
