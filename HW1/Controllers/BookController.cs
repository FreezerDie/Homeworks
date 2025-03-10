using Microsoft.AspNetCore.Mvc;

namespace Library.Controllers;

[ApiController]
[Route("api/[controller]")]
public class BookController: ControllerBase
{
    [HttpPost("Book/Add")]
    public IActionResult AddBook()
    {
        return Ok("Book added!");
    }

    [HttpPost("Book/Update")]
    public IActionResult UpdateBook()
    {
        return Ok("Book updated!");
    }
}