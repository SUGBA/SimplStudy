namespace SimplStudy.Models.DataBaseModels
{
    public class AddressesPoint
    {
        public int Id { get; set; }
        public string? Address { get; set; }

        public Manager? ActiveManager { get; set; }
        public int ManagerId { get; set; }
    }
}
