using InventoryService.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace InventoryService.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        // GET: api/v1/<InventoryController>
        [HttpGet]
        public ActionResult< List<Product> > Get()
        {
            return new List<Product>()
            {
                new Product()
                {
                    Id = 1,
                    Description = "",
                    Sku = "abc12300",
                    Name = "Toy1",
                    DiscountPrice = 20.99m,
                    RegularPrice = 29.99m,
                    Quantity = 100
                },
                new Product()
                {
                    Id = 2,
                    Description = "",
                    Sku = "xyz123",
                    Name = "Toy2",
                    DiscountPrice = 20.99m,
                    RegularPrice = 29.99m,
                    Quantity = 100
                },
                new Product()
                {
                    Id = 3,
                    Description = "",
                    Sku = "abc12300",
                    Name = "Toy3",
                    DiscountPrice = 20.99m,
                    RegularPrice = 29.99m,
                    Quantity = 100
                },
                new Product()
                {
                    Id = 4,
                    Description = "",
                    Sku = "xyz123",
                    Name = "Toy4",
                    DiscountPrice = 20.99m,
                    RegularPrice = 29.99m,
                    Quantity = 100
                },
                new Product()
                {
                    Id = 5,
                    Description = "",
                    Sku = "abc12300",
                    Name = "Toy5",
                    DiscountPrice = 20.99m,
                    RegularPrice = 29.99m,
                    Quantity = 100
                },
                new Product()
                {
                    Id = 6,
                    Description = "",
                    Sku = "xyz123",
                    Name = "Toy6",
                    DiscountPrice = 20.99m,
                    RegularPrice = 29.99m,
                    Quantity = 100
                },
                new Product()
                {
                    Id = 7,
                    Description = "",
                    Sku = "abc12300",
                    Name = "Toy7",
                    DiscountPrice = 20.99m,
                    RegularPrice = 29.99m,
                    Quantity = 100
                },
                new Product()
                {
                    Id = 8,
                    Description = "",
                    Sku = "xyz123",
                    Name = "Toy8",
                    DiscountPrice = 20.99m,
                    RegularPrice = 29.99m,
                    Quantity = 100
                }
            };
        }

        // GET api/v1/<InventoryController>/5
        [HttpGet("{id}")]
        public ActionResult<Product> Get(int id)
        {
            return new Product()
            {
                Id = id,
                Description = "",
                Sku = "xyz123",
                Name = "Toy2",
                DiscountPrice = 20.99m,
                RegularPrice = 29.99m,
                Quantity = 100
            };
        }

        // POST api/v1/<InventoryController>
        [HttpPost]
        public ActionResult<Product> Post([FromBody] Product product)
        {
            return new Product()
            {
                Id = 100,
                Description = product.Description,
                Sku = product.Sku,
                Name = product.Name,
                DiscountPrice = product.DiscountPrice,
                RegularPrice = product.RegularPrice,
                Quantity = product.Quantity
            };
        }

        // PUT api/v1/<InventoryController>/5
        [HttpPut("{id}")]
        public ActionResult<Product> Put(int id, [FromBody] Product product)
        {
            return new Product()
            {
                Id = id,
                Description = product.Description,
                Sku = product.Sku,
                Name = product.Name,
                DiscountPrice = product.DiscountPrice,
                RegularPrice = product.RegularPrice,
                Quantity = product.Quantity
            };
        }

        // DELETE api/v1/<InventoryController>/5
        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(int id)
        {
            return true;
        }
    }
}
