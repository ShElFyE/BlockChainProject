/*using Microsoft.AspNetCore.Mvc;

namespace HelloController.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HelloWorldController : ControllerBase
    {
        private readonly INewService _newService;

        public HelloWorldController(INewService newService)
        {
            _newService = newService;
        }

        [HttpGet]
        public IActionResult GetHelloWorld()
        {
            return Ok("Hello World");
        }

        [HttpGet("newservice")]
        public IActionResult GetNewServiceMessage()
        {
            var message = _newService.GetMessage();
            return Ok(message);
        }
    }
}
*/