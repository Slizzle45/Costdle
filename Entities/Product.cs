namespace Costdle.Entities
{
    public class Product
    {
        public int Id {  get; set; }
        public required string Name { get; set; }
        public byte? Rating { get; set; }
        public string ImageUrl { get; set; }
    }
}
