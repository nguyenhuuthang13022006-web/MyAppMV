using AppMAS.Models;
using Microsoft.AspNetCore.Mvc;

namespace AppMAS.Controllers
{
    public class ProductController : Controller
    {
       
        public IActionResult Index()
        {
            var categories = GetCategories();
            var products = GetProducts();

            ViewBag.Categories = categories;

            return View(products);
        }

       
        public IActionResult Category(int id)
        {
            var categories = GetCategories();
            var products = GetProducts();

            var result = products
                .Where(p => p.CategoryId == id)
                .ToList();

            ViewBag.Categories = categories;

            return View("Index", result);
        }

        public IActionResult Details(int id)
        {
            var products = GetProducts();

            var product = products.FirstOrDefault(p => p.Id == id);

            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

      
        private List<Category> GetCategories()
        {
            return new List<Category>
            {
                new Category { Id = 1, Name = "Quần áo" },
                new Category { Id = 2, Name = "Túi xách" },
                new Category { Id = 3, Name = "Đồng hồ" },
                new Category { Id = 4, Name = "Ti vi" },
                new Category { Id = 5, Name = "Tủ lạnh" },
                new Category { Id = 6, Name = "Máy bơm" },
                new Category { Id = 7, Name = "Quạt điện" },
                new Category { Id = 8, Name = "Loa" }
            };
        }

        private List<Product> GetProducts()
        {
            return new List<Product>
            {
                new Product
                {
                    Id = 1,
                    Name = "Bộ đồ bơi cho trẻ em nam",
                    Image = "/images/product1.webp",
                    Price = 500000,
                    SalePrice = 350000,
                    CategoryId = 1,
                    Description = "Bộ đồ bơi cho trẻ em nam.",
                    Status = "Còn hàng",
                    CreatedAt = new DateTime(2021, 7, 15, 12, 0, 0)
                },

                new Product
                {
                    Id = 2,
                    Name = "Bộ đồ bơi cho trẻ em nữ",
                    Image = "/images/product2.webp",
                    Price = 500000,
                    SalePrice = 350000,
                    CategoryId = 1,
                    Description = "Bộ đồ bơi cho trẻ em nữ.",
                    Status = "Còn hàng",
                    CreatedAt = new DateTime(2021, 7, 15, 12, 0, 0)
                },

                new Product
                {
                    Id = 3,
                    Name = "Bộ đồ bơi cho trẻ em 3-5 tuổi",
                    Image = "/images/product3.webp",
                    Price = 500000,
                    SalePrice = 350000,
                    CategoryId = 1,
                    Description = "Bộ đồ bơi cho trẻ em 3-5 tuổi.",
                    Status = "Còn hàng",
                    CreatedAt = new DateTime(2021, 7, 15, 12, 0, 0)
                },

                new Product
                {
                    Id = 4,
                    Name = "Bộ đồ bơi cho trẻ em trai",
                    Image = "/images/product4.webp",
                    Price = 500000,
                    SalePrice = 350000,
                    CategoryId = 1,
                    Description = "Bộ đồ bơi cho trẻ em trai.",
                    Status = "Còn hàng",
                    CreatedAt = new DateTime(2021, 7, 15, 12, 0, 0)
                },

                new Product
                {
                    Id = 5,
                    Name = "Túi thời trang mẫu mới 2021",
                    Image = "/images/product5.webp",
                    Price = 500000,
                    SalePrice = 350000,
                    CategoryId = 2,
                    Description = "Túi thời trang mẫu mới 2021.",
                    Status = "Còn hàng",
                    CreatedAt = new DateTime(2021, 7, 15, 12, 0, 0)
                },

                new Product
                {
                    Id = 6,
                    Name = "Túi thời trang da cá sấu",
                    Image = "/images/product6.webp",
                    Price = 500000,
                    SalePrice = 350000,
                    CategoryId = 2,
                    Description = "Túi thời trang da cá sấu.",
                    Status = "Còn hàng",
                    CreatedAt = new DateTime(2021, 7, 15, 12, 0, 0)
                }
            };
        }
    }
}