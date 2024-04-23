using Costdle.Data;
using Costdle.Entities;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace Costdle.Controllers
{
    public class ProductController : Controller
    {
        private readonly DataContext _dbContext;

        public ProductController(DataContext dbcontext)
        {
            _dbContext = dbcontext;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllHeroes()
        {
            var products = new List<Product>
            {
                new Product
                {
                    Id = 1,
                    Name = "Kalem",
                    Rating = 4,
                    ImageUrl = "https://images-eu.ssl-images-amazon.com/images/I/51rdf4UTXHL._AC_UL450_SR450,320_.jpg"
                }
            };

            return Ok(products);
        }

        //Create
        [HttpPost]
        public IActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
                _dbContext.Products.Add(product);
                _dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(product);
        }
    }
}
