using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SportOutlet.Data;
using SportOutlet.Data.Models;
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
                if (gender == Gender.Man)
                {
                    query = query.Where(p => p.Gender == Gender.Man || p.Gender == Gender.Unisex);
                }
                else if (gender == Gender.Woman)
                {
                    query = query.Where(p => p.Gender == Gender.Woman || p.Gender == Gender.Unisex);
                }
                else
                {
                    query = query.Where(p => p.Gender == gender);
                }

            }

            var products = await query.ToListAsync();

            ViewBag.Categories = _dbContext.Categories
                .Include(p => p.SubCategories)
                .ToList();

            ViewBag.Brands = await _dbContext.Brands.ToListAsync();

            ViewBag.SubCategory = products.FirstOrDefault()?.SubCategory?.Name ?? "Products";

            return View(products);
        }

        public async Task<IActionResult> Details (Guid Id)
        {
            var product = await _dbContext.Products
                .Include(p => p.ProductVariants)
                .Include(p => p.ProductSpecifications)
                .Include(p => p.ProductImages)
                .Include(p => p.Brand)
                .Include(p => p.SubCategory)
                .FirstOrDefaultAsync(p => p.Id == Id);

            if (product == null) 
            {
                return NotFound();
            }

            string? targetedClotheToCombine = null;

            if (product.SubCategory.Name == "T-Shirts")
            {
                targetedClotheToCombine = "Shorts";
            }
            else if (product.SubCategory.Name == "Sweatshirt")
            {
                targetedClotheToCombine = "Pants";
            }
            else if (product.SubCategory.Name == "Shorts")
            {
                targetedClotheToCombine = "T-Shirts";
            }
            else if (product.SubCategory.Name == "Pants")
            {
                targetedClotheToCombine = "Sweatshirt";
            }

            List<Product> outfit = new();

            if (targetedClotheToCombine != null) 
            {
                outfit = await _dbContext.Products
                   .Include(p => p.SubCategory)
                   .Include(p => p.Brand)
                   .Include(p => p.ProductImages)
                   .Where(p => p.SubCategory.Name == targetedClotheToCombine && p.Gender == product.Gender && p.Id != product.Id)
                   .Where(p => p.Brand.Id == product.Brand.Id)
                   .OrderBy(random => Guid.NewGuid())
                   .Take(3)
                   .ToListAsync();
            }
            else
            {
                outfit = await _dbContext.Products
                        .Include(p => p.SubCategory)
                        .Include(p => p.Brand)
                        .Include(p => p.ProductImages)
                        .Where(p => p.SubCategory.Name == product.SubCategory.Name && p.Gender == product.Gender && p.Id != product.Id)
                        .Where(p => p.Brand.Id == product.Brand.Id)
                        .OrderBy(random => Guid.NewGuid())
                        .Take(3)
                        .ToListAsync();
            }
                
            var similarProducts = await _dbContext.Products
                .Include(p => p.SubCategory)
                .Include(p => p.ProductImages)
                .Where(p => p.SubCategory.Id == product.SubCategory.Id && p.Id != product.Id)
                .Where(p => p.Gender == product.Gender || p.Gender == Gender.Unisex)
                .OrderBy(random => Guid.NewGuid())
                .Take(3)
                .ToListAsync();

            ViewBag.Outfits = outfit;

            ViewBag.SimilarProducts = similarProducts;

            return View(product);
        }
    }
}
