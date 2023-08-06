using System.ComponentModel.DataAnnotations.Schema;

namespace SimplStudy.Models.DataBaseModels
{
    public class Order
    {
        public int Id { get; set; }

        //public int TotalPrice
        //{
        //    get { return Items.Sum(x => x.ActiveProduct!.Price); }
        //    private set { }
        //}

        //public int TotalCount
        //{
        //    get { return Items.Sum(x => x.Count); }
        //    private set { }
        //}

        public int TotalPrice { get; set; }

        public int TotalCount { get; set; }

        public List<Item> Items { get; set; } = new List<Item>();
    }
}
