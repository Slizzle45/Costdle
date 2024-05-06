namespace Costdle.Models

{
    public class Product
    {
        public int Id {  get; set; }
        public required string Name { get; set; }
        public byte? Rating { get; set; }
        public required string ImageUrl { get; set; }
    }
}
