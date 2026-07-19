using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerce.Domain.DTOs.Cart.cartdto
{
    public class cartiteminputdto
    {
         public int? ProductId { get; set; }
        public int Quantity { get; set; }
         public int? VariantId { get; set; }
     }
}
