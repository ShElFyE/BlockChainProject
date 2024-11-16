/*using Microsoft.AspNetCore.Mvc;

public class HelloWorldController : ControllerBase
{
    private readonly IMyRepository _repository;

    public HelloWorldController(IMyRepository repository)
    {
        _repository = repository;
    }

    [HttpGet("repository-message")]
    public IActionResult GetRepositoryMessage()
    {
        var message = _repository.GetTestMessage();
        return Ok(message);
    }
}
*/