using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerce.Domain.Models
{
    public class ReviewImage
    {
        public int ReviewImageId { get; set; }
        [ForeignKey("Rating")]
        public int RatingId { get; set; }
        public string ImageUrl { get; set; }
        public  Rating Rating { get; set; }
    }
}
