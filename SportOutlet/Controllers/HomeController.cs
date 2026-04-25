using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SportOutlet.Data;
using SportOutlet.Data.Models;
using SportOutlet.Models;

namespace SportOutlet.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly SportOutletDbContext _dbContext;

        public HomeController(ILogger<HomeController> logger, SportOutletDbContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }

        public async Task<IActionResult> Index()
        {
          var products = await _dbContext.Products
                .Include(p => p.ProductImages)
                .Include(p => p.Brand)
                .Include(p => p.SubCategory)
                .ThenInclude(sc => sc.Category)
                .ToListAsync();

            var categories = await _dbContext.Categories
                .Include(c => c.SubCategories)
                .Include(c => c.CategoryImages)
                .ToListAsync();

            var brands = await _dbContext.Brands.ToListAsync();

            ViewBag.Categories = categories;
            ViewBag.Brands = brands;

            return View(products);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
