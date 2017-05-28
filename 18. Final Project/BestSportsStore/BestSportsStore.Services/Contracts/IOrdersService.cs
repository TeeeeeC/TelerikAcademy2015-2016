namespace BestSportsStore.Services.Contracts
{
    using BestSportsStore.Data.Models;
    using System.Linq;

    public interface IOrdersService
    {
        IQueryable<Order> GetByUserId(string userId);
    }
}
