using ECommerce.Domain.DTOs;
using ECommerce.Domain.Models;

namespace ECommerce.Domain.Interfaces
{
    public interface IAuth
    {
       public Task<TokenResult> RegisterForAdminAsync(AdminRegisterDto dto);
       Task<TokenResult> RegisterForCustomerAsync(CustomerRegisterDto dto);
       Task<TokenResult> RegisterForSellerAsync(SellerRegisterDto dto);
       Task<TokenResult> LoginAsync(logindto logindto);
        Task AddAdmin(admin admin);
        Task AddCustomer(customer customer);
        Task AddSeller(seller seller);
        Task<roledto> addrole(roledto dto);
        Task<TokenResponseDto> RefreshTokenAsync(string refreshToken);
        Task<string> changepassword(ChangePasswordDto dto);
        Task savechanged();
    }
}
