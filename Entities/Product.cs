﻿namespace Costdle.Entities
{
    public class Product
    {
        public int Id {  get; set; }
        public required string Name { get; set; }
        public string Description { get; set; }
        public required byte[] Image { get; set; }
    }
}