namespace VinylShop.API.Models
{
    public class Vinyl
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Artist { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }
    }
}
