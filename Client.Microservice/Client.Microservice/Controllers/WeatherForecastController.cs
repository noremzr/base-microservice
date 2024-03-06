using Microsoft.AspNetCore.Mvc;

namespace Client.Microservice.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClientController : ControllerBase
    {
        public ClientController() { }

        [HttpGet()]
        public IEnumerable<ClientModel> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new ClientModel
            {
                CreatedAt = DateTime.Now,
                ID = Random.Shared.Next(-20, 55),
            })
            .ToArray();
        }
    }
}