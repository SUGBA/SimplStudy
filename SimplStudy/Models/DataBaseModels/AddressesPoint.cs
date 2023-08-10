using System.ComponentModel.DataAnnotations;

namespace SimplStudy.Models.DataBaseModels
{
    public class AddressesPoint
    {
        public int Id { get; set; }

        public string? Address { get; set; }

        public IEnumerable<Manager> Managers { get; set; } = Array.Empty<Manager>();

        public IEnumerable<Store> Stores { get; set; } = Array.Empty<Store>();

        public IEnumerable<Buyer> Buyers { get; set; } = Array.Empty<Buyer>();
    }
}
