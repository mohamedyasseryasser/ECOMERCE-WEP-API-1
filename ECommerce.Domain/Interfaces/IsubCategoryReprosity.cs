using ECommerce.Domain.DTOs;

namespace ECommerce.Domain.Interfaces
{
    public interface IsubCategoryReprosity
    {
        Task<PagedResult<SubCategoryDto>> GetAllSubCategoryAsync(int pageNumber, int pageSize, bool isactive);
        Task<SubCategoryDto> GetByIdAsync(int id);
        Task<IEnumerable<SubCategoryDto>> SearchByNameAsync(string name, bool includeisinactive = false);
        Task<SubCategoryResponse> CreateAsync(SubCategoryDto dto);
        Task<SubCategoryResponse> UpdateAsync(int id, SubCategoryDto dto);
        Task<SubCategoryResponse> UpdateImageUrlAsync(int id, string imagepath);
        Task<bool> DeleteAsync(int id);
    }
}
