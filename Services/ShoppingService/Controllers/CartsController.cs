using Microsoft.AspNetCore.Mvc;
using ShoppingService.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ShoppingService.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class CartsController : ControllerBase
    {
        // GET: api/v1/<CartsController>
        [HttpGet]
        public ActionResult<int[]> Get()
        {
            return new int[] { 100, 101, 102, 103, 200, 201, 600 };

        }

        // GET api/v1/<CartsController>/5
        [HttpGet("{id}")]
        public ActionResult<Cart> Get(int id)
        {
            return new Cart()
            {
                Id = id,
                Items = new List<Product>()
                {
                    new Product()
                    {
                        Id = 33,
                        Description = "",
                        Sku = "abc123",
                        Name = "Laptop",
                        DiscountPrice = 20.99m,
                        RegularPrice = 29.99m,
                        Quantity = 82
                    },
                    new Product()
                    {
                        Id = 14,
                        Description = "",
                        Sku = "xyz1238",
                        Name = "iPhone",
                        DiscountPrice = 20.99m,
                        RegularPrice = 29.99m,
                        Quantity = 67
                    },
                    new Product()
                    {
                        Id = 20,
                        Description = "",
                        Sku = "xyz1239",
                        Name = "Jacket",
                        DiscountPrice = 20.99m,
                        RegularPrice = 29.99m,
                        Quantity = 405
                    }
                }
            };
        }

        // POST api/v1/<CartsController>
        [HttpPost]
        public ActionResult<Cart> Post([FromBody] Cart cart)
        {
            return new Cart()
            {
                Id = 100,
                Items = cart.Items
            };
        }

        // PUT api/v1/<CartsController>/5
        [HttpPut("{id}")]
        public ActionResult<Cart> Put(int id, [FromBody] Cart cart)
        {
            return new Cart()
            {
                Id = id,
                Items = cart.Items
            };
        }

        // DELETE api/v1/<CartsController>/5
        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(int id)
        {
            return true;
        }
    }
}
