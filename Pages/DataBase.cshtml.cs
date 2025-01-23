using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Application.Pages
{
    public class DataBaseModel : PageModel
    {
        public class Product
        {
            public int Id { get; set; }
            public decimal Price { get; set; }
            public string Size { get; set; }
        }

        public List<Product> Products { get; set; } = new List<Product>();
        
        public void OnPost(int productId, decimal price, string size, string action)
        {
            if (action == "Add")
            {
                Products.Add(new Product
                {
                    Id = productId,
                    Price = price,
                    Size = size
                });
            }
            else if (action == "Delete")
            {
                Products = Products.Where(p => p.Id != productId).ToList();
            }
        }
    }
}