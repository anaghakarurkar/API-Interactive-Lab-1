using Microsoft.AspNetCore.Mvc;
using API_Interactive_Lab_1.Models;

namespace API_Interactive_Lab_1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CoffeeController : ControllerBase
    {
        [HttpGet("lover")]
        public string GetCoffeeLover()
        {
            return "I like coffee!";
        }

        [HttpGet("{name}")]

        public Coffee Get(string? name)
        {
            return new Coffee
            {
                Name = name ?? "latte",
                ID = (name != null ? 7 : -1)
            };

        }
    }
}
