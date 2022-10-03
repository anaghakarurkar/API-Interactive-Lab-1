using Microsoft.AspNetCore.Mvc;

namespace API_Interactive_Lab_1.Controllers
{
    [ApiController]
    [Route("Home")]
    public class HomeController : ControllerBase
    {
        [Route("")]
        [Route("/")]
        [HttpGet]
        public string Get()
        {
            return "Welcome to the Drinks API!"; ;
        }
    }
}
