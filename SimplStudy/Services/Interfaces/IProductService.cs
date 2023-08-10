using SimplStudy.Models.DataBaseModels;

namespace SimplStudy.Services.Interfaces
{
    public interface IProductService
    {
        public Task<List<Product>> GetProductsAsync();
    }
}
