using Costdle.Data;
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
        public IActionResult Index()
        {
            return View();
        }
        //Create

    }
}
