namespace MVC03.Models
{
    public class ProductModel
    {
        public int ProductID { get; set; }
        public string? ProductName { get; set; }
        public string? ImageURL { get; set; }
        public float ProductPrice { get; set; }
        public string? Description { get; set; }
        public static List<ProductModel> GetProducts()
        {
            return new List<ProductModel>
            {
                new ProductModel { ProductID = 1, ProductName = "Laptop", ImageURL = "/Images/laptop.jpg", ProductPrice = 1500, Description = "Laptop Description" },
                new ProductModel { ProductID = 2, ProductName = "Headphone", ImageURL = "/Images/headphone.jpg", ProductPrice = 2000, Description = "Headphone Description" },
                new ProductModel { ProductID = 3, ProductName = "Table", ImageURL = "/Images/tablet.jpg", ProductPrice = 800, Description = "Tablet Description" },
                new ProductModel { ProductID = 4, ProductName = "Table", ImageURL = "/Images/tablet.jpg", ProductPrice = 800, Description = "Tablet Description" },
                new ProductModel { ProductID = 5, ProductName = "Table", ImageURL = "/Images/tablet.jpg", ProductPrice = 800, Description = "Tablet Description" },
                new ProductModel { ProductID = 6, ProductName = "Table", ImageURL = "/Images/tablet.jpg", ProductPrice = 800, Description = "Tablet Description" },
                new ProductModel { ProductID = 7, ProductName = "Table", ImageURL = "/Images/tablet.jpg", ProductPrice = 800, Description = "Tablet Description" },
                new ProductModel { ProductID = 8, ProductName = "Table", ImageURL = "/Images/tablet.jpg", ProductPrice = 800, Description = "Tablet Description" }, 
                new ProductModel { ProductID = 9, ProductName = "Table", ImageURL = "/Images/tablet.jpg", ProductPrice = 800, Description = "Tablet Description" }, 
                new ProductModel { ProductID = 10, ProductName = "Table", ImageURL = "/Images/tablet.jpg", ProductPrice = 800, Description = "Tablet Description" }, 
            };
        }
        
    }
}
