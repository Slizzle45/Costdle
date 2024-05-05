using Costdle.Data;
using Costdle.Entities;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
            var products = await _dbContext.Products.ToListAsync();

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
