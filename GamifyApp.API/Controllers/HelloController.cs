using Microsoft.AspNetCore.Mvc;
using GamifyApp.Contracts.Domain.Services;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860
namespace GamifyApp.API.Controllers
{
    [Route("api/[controller]")]
    public class HelloController : Controller
    {
        private readonly IHelloService helloService;
        public HelloController(IHelloService helloService)
        {
            this.helloService = helloService;
        }

        // GET: api/values/Name
        [HttpGet("{name}")]
        public string Get(string name)
        {
            return helloService.Hello(name);
        }
                
    }
}
