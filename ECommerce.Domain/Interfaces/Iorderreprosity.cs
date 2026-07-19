using ECommerce.Domain.DTOs;
using ECommerce.Domain.DTOs.orderdto;

namespace ECommerce.Domain.Interfaces
{
    public interface Iorderreprosity
    {
        Task<orderresponsedto> createorder(createorderdto orderDto);
        Task<orderresponsedto> GetOrderByIdAsync(int orderId);
        Task<List<orderresponsedto>> getorders(PaginationDto pagination);
        Task<int> getorderscount();
        Task<List<orderresponsedto>> getorderbycustomerid(int customerid, PaginationDto pagination);
        Task<(bool success, string message)> canselorder(int orderid);
        Task<(bool success, string message)> cansledsuborder(int suborderid);
        Task<orderresponsedto> updateorder(int id, updateinputorderdto orderDto);
        Task<bool> OrderExistsAsync(int id);
        Task<bool> deleteorder(int orderid);
    }
}
