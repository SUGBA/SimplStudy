using SimplStudy.Models.DataBaseModels;

namespace SimplStudy.Repositories.Interfaces
{
    public interface IProductRepository
    {
        public Task<List<Product>> GetProductsAsync();
    }
}
