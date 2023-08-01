namespace SimplStudy.Models.DataBaseModels
{
    public class Manager
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int HoursProduction { get; set; }

        public AdressesPoint? Adress { get; set; }
        public int AdressesPointsId { get; set; }
    }
}
