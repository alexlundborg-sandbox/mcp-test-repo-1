using HelloWorld;
using Microsoft.AspNetCore.Mvc;

namespace HelloWorld.Api.Controllers;

/// <summary>
/// API controller for greeting endpoints.
/// </summary>
[ApiController]
[Route("api/[controller]")]
public class GreetingController : ControllerBase
{
    private readonly IGreetingService _greetingService;

    public GreetingController(IGreetingService greetingService)
    {
        _greetingService = greetingService;
    }

    /// <summary>
    /// Gets the default "Hello, World!" greeting.
    /// </summary>
    /// <returns>A greeting message.</returns>
    [HttpGet]
    public ActionResult<string> GetGreeting()
    {
        return Ok(_greetingService.GetGreeting());
    }

    /// <summary>
    /// Gets a personalized greeting for the specified name.
    /// </summary>
    /// <param name="name">The name to include in the greeting.</param>
    /// <returns>A personalized greeting message.</returns>
    [HttpGet("{name}")]
    public ActionResult<string> GetGreeting(string name)
    {
        return Ok(_greetingService.GetGreeting(name));
    }
}
