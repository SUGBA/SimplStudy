using System.ComponentModel.DataAnnotations;

namespace SimplStudy.Models.DataBaseModels
{
    public class AddressesPoint
    {
        public int Id { get; set; }
        public string? Address { get; set; }

        public Manager? ActiveManager { get; set; }

        public Store? AcitveStore { get; set; }
        public int StoreId { get; set; }

        public Buyer? AcitveBuyer { get; set; }
        public int BuyerId { get; set; }
    }
}
