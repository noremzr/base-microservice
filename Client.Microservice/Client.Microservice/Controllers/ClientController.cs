using Microsoft.AspNetCore.Mvc;
using System.IO;

namespace Client.Microservice.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClientController : ControllerBase
    {
        public ClientController() { }

        [HttpGet()]
        public async Task<IEnumerable<ClientModel>> Get()
        {
            //string path = "http://product-api/Product";

            //HttpClient client = new HttpClient();
            //try
            //{

            //    HttpResponseMessage response = await client.GetAsync(path);
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}

            return Enumerable.Range(1, 5).Select(index => new ClientModel
            {
                CreatedAt = DateTime.Now,
                ID = Random.Shared.Next(-20, 55),
            })
            .ToArray();
        }

        [HttpGet("{id}")]
        public async Task<IEnumerable<ClientModel>> Get(int id)
        {
            string path = "http://product-microservice/Product";

            HttpClient client = new HttpClient();
            try
            {

                HttpResponseMessage response = await client.GetAsync(path);
                Console.WriteLine(response.Content);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }

            return Enumerable.Range(1, 5).Select(index => new ClientModel
            {
                CreatedAt = DateTime.Now,
                ID = Random.Shared.Next(-20, 55),
            })
            .ToArray();
        }


    }
}