using Costdle.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Costdle.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : HomeController
    {
        private readonly DataContext _dbContext;

        public ProductController(DataContext dbcontext)
        {
            _dbContext = dbcontext;
        }

        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetAllProducts()
        {
            var products = await _dbContext.Products.ToListAsync();

            return Ok(products);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProduct(int id)
        {
            var product = await _dbContext.Products.FindAsync(id);
            if(product is null)
                return NotFound("Hero not found.");
            return Ok(product);
        }

        //Create
        [HttpPost]
        public async Task<ActionResult<List<Product>>> CreateProduct(Product product)
        {
            if(ModelState.IsValid)
            {
                _dbContext.Products.Add(product);
                await _dbContext.SaveChangesAsync();
                //return RedirectToAction("Index");
            }
            return Ok(await _dbContext.Products.ToListAsync());
        }
    }
}
