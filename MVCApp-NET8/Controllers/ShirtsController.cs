using Microsoft.AspNetCore.Mvc;

namespace MVCApp_NET8.Controllers
{
    [ApiController]
    [Route("/api/[controller]")] // [controller] represents shirts
    public class ShirtsController : ControllerBase
    {
        [HttpGet]
        public string GetShirts()
        {
            return "Reading all the shirts";
        }

        [HttpGet("{id}")]
        public string GetShirtById(int id)
        {
            return $"Reading shirt with ID: {id}";
        }

        [HttpPost]
        public string CreateShirt()
        {
            return "Creating a new shirt";
        }

        [HttpPut("{id}")]
        public string UpdateShirt(int id)
        {
            return $"Updating shirt with ID: {id}";
        }

        [HttpDelete("{id}")]
        public string DeleteShirt(int id)
        {
            return $"Deleting shirt with ID: {id}";
        }
    }
}
