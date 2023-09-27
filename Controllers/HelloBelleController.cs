using HelloBelle.Services;
using Microsoft.AspNetCore.Mvc;

namespace HelloBelle.Controllers;

[Route("hellobelle")]
[ApiController]
public class HelloBelleController : ControllerBase
{
    private readonly IMessageService _messageService;

    public HelloBelleController(IMessageService messageService)
    {
        _messageService = messageService ?? throw new ArgumentNullException(nameof(messageService));
    }

    [HttpGet]
    [Route("GetMessageForTheDay")]
    public IActionResult GetMessageForTheDay()
    {
        var message = _messageService.GetMessageForTheDay();
        return Ok(message);
    }
    
    [HttpGet]
    [Route("Error")]
    public IActionResult GiveError()
    {
       
        return Ok("Error");
    }
}