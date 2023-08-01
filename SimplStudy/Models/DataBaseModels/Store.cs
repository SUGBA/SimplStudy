namespace SimplStudy.Models.DataBaseModels
{
    public class Store
    {
        public int Id{ get; set; }
        public string? Name { get; set; }

        public int AdressesPointId { get; set; }
        public AdressesPoint? Address { get; set; }
    }
}
