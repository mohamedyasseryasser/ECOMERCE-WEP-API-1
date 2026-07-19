using ECommerce.Domain.Enums;

namespace ECommerce.Domain.DTOs
{
    public class Productfilterdto
    {
        public int? CategoryId { get; set; }
        public int? SubcategoryId { get; set; }
        public decimal? MinPrice { get; set; }
        public decimal? MaxPrice { get; set; }
        public string SearchTerm { get; set; }
        public string SortBy { get; set; }
        public sortdirection SortDirection { get; set; }
    }
}
