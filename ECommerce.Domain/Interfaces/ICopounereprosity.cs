using ECommerce.Domain.DTOs.couponsdto;

namespace ECommerce.Domain.Interfaces
{
    public interface ICopounereprosity
    {
        public Task<couponresponsedto> createcopoune(createcouponinputdto dto);
        public Task<bool> codecouponeexit(string code);
        public Task<couponresponsedto> GetCouponByIdAsync(int couponId);
        public Task<couponresponsedto> updatecoupone(updatecouponedto couponDto);
        public Task<bool> deletecoupone(int id);

    }
}
