using Microsoft.AspNetCore.Mvc;
using MVC03.Models;

namespace MVC03.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult ProductList()
        {
            // Lấy danh sách sản phẩm từ Model
            var products = ProductModel.GetProducts();
            return View(products);
        }

        public IActionResult ProductDetail(int id)
        {
            // Lấy sản phẩm theo ID
            var product = ProductModel.GetProducts().FirstOrDefault(p => p.ProductID == id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }
    }
}
