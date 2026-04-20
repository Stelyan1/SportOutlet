using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SportOutlet.Data;
using SportOutlet.Data.Models.Enums;

namespace SportOutlet.Controllers
{
    public class ProductsController : Controller
    {
        private readonly SportOutletDbContext _dbContext;

        public ProductsController(SportOutletDbContext dbContext)
        {
          _dbContext = dbContext;  
        }


        public async Task<IActionResult> Index(Guid? subCategoryId, Gender? gender)
        {
            var query = _dbContext.Products
                .Include(p => p.ProductImages)
                .Include(p => p.Brand)
                .Include(p => p.SubCategory)
                .AsQueryable();

            if (subCategoryId.HasValue)
            {
                query = query.Where(p => p.SubCategoryId == subCategoryId);
            }

            if (gender.HasValue) 
            {
                query = query.Where(p => p.Gender == gender);
            }

            var products = await query.ToListAsync();

            ViewBag.Categories = _dbContext.Categories
                .Include(p => p.SubCategories)
                .ToList();

            ViewBag.Brands = _dbContext.Brands.ToList();

            ViewBag.SubCategory = products.FirstOrDefault()?.SubCategory?.Name ?? "Products";

            return View(products);
        }
    }
}
