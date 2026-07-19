using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace ECommerce.Domain.Models
{
    public class applicationuser:IdentityUser
    {
        [Required]
        public DateTime lastlogin { get; set; }
        [Required]
        public DateTime createdAt { get; set; }
        [Required]
        public DateTime updatedAt { get; set; }
        public bool? IsActive { get; set; }
        public string? RefreshToken { get; set; }
        public DateTime? RefreshTokenExpiryTime { get; set; }
        public ICollection<address>? addresses { get; set; }=new List<address>();
    }
}
