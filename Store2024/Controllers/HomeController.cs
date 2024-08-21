using Microsoft.AspNetCore.Mvc;
using Store2024.Models;
using System.Diagnostics;
using System.Text.Json;
using System.Net.Http;

namespace Store2024.Controllers
{
    public class HomeController : Controller
    {
        private static string ACCOUNT_SERVICE_API_BASE = Environment.GetEnvironmentVariable("ACCOUNT_SERVICE_API_BASE");
        private static string INVENTORY_SERVICE_API_BASE = Environment.GetEnvironmentVariable("INVENTORY_SERVICE_API_BASE");
        private static string SHOPPING_SERVICE_API_BASE = Environment.GetEnvironmentVariable("SHOPPING_SERVICE_API_BASE");
        private HttpClient http;
        
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            ACCOUNT_SERVICE_API_BASE = ACCOUNT_SERVICE_API_BASE ?? "http://localhost:5173";
            INVENTORY_SERVICE_API_BASE = INVENTORY_SERVICE_API_BASE ?? "http://localhost:5180";
            SHOPPING_SERVICE_API_BASE = SHOPPING_SERVICE_API_BASE ?? "http://localhost:5219";

            _logger = logger;
            http = new HttpClient();
        }

        public async Task<ActionResult> Index()
        {
            // Fetch user data from AccountService API and instantiate model with said data
            Consumer user = null;
            var userResponse = await http.GetAsync($"{ACCOUNT_SERVICE_API_BASE}/api/v1/consumers/5");
            if (userResponse.IsSuccessStatusCode)
            {
                var userData = userResponse.Content.ReadAsStringAsync().Result;
                user = JsonSerializer.Deserialize<Consumer>(userData);
            }

            // Fetch products data from InventoryService API and instantiate model with said data
            List<Product> product = null;
            var productResponse = await http.GetAsync($"{INVENTORY_SERVICE_API_BASE}/api/v1/products");
            if (productResponse.IsSuccessStatusCode)
            {
                var productData = productResponse.Content.ReadAsStringAsync().Result;
                product = JsonSerializer.Deserialize<List<Product>>(productData);
            }

            // Fetch cart data from ShoppingService API and instantiate model with said data
            Cart cart = null;
            var cartResponse = await http.GetAsync($"{SHOPPING_SERVICE_API_BASE}/api/v1/carts/30");
            if (cartResponse.IsSuccessStatusCode)
            {
                var cartData = cartResponse.Content.ReadAsStringAsync().Result;
                cart = JsonSerializer.Deserialize<Cart>(cartData);
            }

            // Create commerce instance with the models generated from the API calls and generate a view with this instance
            var commerce = new Commerce()
            {
                User = user,
                Products = product,
                Cart = cart
            };

            return View(commerce);
        }

        public async Task<ActionResult> About()
        {
            // Fetch user data from AccountService API and instantiate model with said data
            Consumer user = null;
            var userResponse = await http.GetAsync($"{ACCOUNT_SERVICE_API_BASE}/api/v1/consumers/5");
            if (userResponse.IsSuccessStatusCode)
            {
                var userData = userResponse.Content.ReadAsStringAsync().Result;
                user = JsonSerializer.Deserialize<Consumer>(userData);
            }

            // Fetch products data from InventoryService API and instantiate model with said data
            List<Product> product = null;
            var productResponse = await http.GetAsync($"{INVENTORY_SERVICE_API_BASE}/api/v1/products");
            if (productResponse.IsSuccessStatusCode)
            {
                var productData = productResponse.Content.ReadAsStringAsync().Result;
                product = JsonSerializer.Deserialize<List<Product>>(productData);
            }

            var commerce = new Commerce()
            {
                User = user,
                Products = product
            };

            return View(commerce);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
