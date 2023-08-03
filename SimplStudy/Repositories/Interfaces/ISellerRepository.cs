using SimplStudy.Models.DataBaseModels;

namespace SimplStudy.Repositories.Interfaces
{
    public interface ISellerRepository
    {
        public List<Seller> GetSellers();
    }
}
