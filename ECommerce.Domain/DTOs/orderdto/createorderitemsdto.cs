using ECommerce.Domain.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerce.Domain.DTOs.orderdto
{
    public class createorderitemsdto
    {
        [Required]
        public int ProductId { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Quantity must be at least 1")]
        public int Quantity { get; set; }

        public int? VariantId { get; set; }

        // These properties will be calculated by the backend
        public decimal PriceAtPurchase { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
