using ECommerce.Domain.DTOs;
using ECommerce.Domain.Models;

namespace ECommerce.Domain.Interfaces
{
    public interface IUser
    {
        Task<Userdto> getuserbyid(useridandroledto dto);
        Task<UserStatusUpdateDto> updateuserstate(string userid, UserStatusUpdateDto dto);
        Task<UserStatusUpdateDto> deleteuser(string userid);
        Task<PagedResult<CustomerResponsedto>> GetAllCustomersAsync(int pageNumber, int pageSize);
        Task<CustomerResponsedto> getcustomerbyid(int customerid);
        Task<bool> updatecustomer(customerupdatedto dto);
        Task<UserStatusUpdateDto> deletecustomer(int customerid);
        Task<PagedResult<SellerResponseDto>> GetAllSellersAsync(int pageNumber, int pageSize);
        Task<SellerResponseDto> GetSellerByIdAsync(int sellerId);
        Task<bool> UpdateSellerAsync(SellerUpdateDto dto);
        Task<UserStatusUpdateDto> DeleteSellerAsync(int sellerId);
    //    Task<bool> SaveChangesAsync();
    }
}
