using ECommerce.Domain.DTOs;
using ECommerce.Domain.Models;

namespace ECommerce.Domain.Interfaces
{
    public interface ICategoryReprosity
    {
        Task<PagedResult<CategoryDto>> GetAllCategoryAsync(int pageNumber, int pageSize,bool isactive);
        Task<CategoryDto> GetByIdAsync(int id);
        Task<IEnumerable<CategoryDto>> SearchByNameAsync(string name, bool includeisinactive = false);
    Task<categoryresponse> CreateAsync(CategoryDto dto);
        Task<categoryresponse> UpdateAsync(int id, CategoryDto entity);
        Task<bool> DeleteAsync(int id);
        Task<categoryresponse> updateimageurl(int id, string imagepath);
    }
}
