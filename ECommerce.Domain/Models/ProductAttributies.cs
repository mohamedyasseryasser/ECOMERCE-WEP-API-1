using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerce.Domain.Models
{
    public class ProductAttributies
    {
        [Key]
        public int ProductAttriid {  get; set; }
        [Required]
        public string AttributeName {  get; set; }
        public string Type { get; set; }
        public string PossibleValues { get; set; } 
        public bool? IsRequired { get; set; }
        public bool? IsFilterable { get; set; }
        [ForeignKey("SubCategory")]
        public int subcatid {  get; set; }
        public SubCategory SubCategory { get; set; }
        public ICollection<ProductAttributiesValue>? productAttributiesValues {  get; set; }=new List<ProductAttributiesValue>();
    }
}
