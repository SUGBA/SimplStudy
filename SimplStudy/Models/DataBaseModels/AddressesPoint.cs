using System.ComponentModel.DataAnnotations;

namespace SimplStudy.Models.DataBaseModels
{
    public class AddressesPoint
    {
        public int Id { get; set; }

        public string? Address { get; set; }

        public List<Manager> Managers { get; set; } = new List<Manager>();

        public List<Store> Stores { get; set; } = new List<Store>();

        public List<Buyer> Buyers { get; set; } = new List<Buyer>();
    }
}
