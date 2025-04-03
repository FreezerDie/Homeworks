using Library.DTO.Requests.Author;
using Microsoft.AspNetCore.Mvc;

namespace Library.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AuthorController: ControllerBase
{
    [HttpPost("Add")]
    public async Task<IActionResult> AddAuthor(AuthorAddRequest request)
    {
        return Ok("Author added!");
    }

    [HttpPost("Update")]
    public async Task<IActionResult> UpdateAuthor(AuthorUpdateRequest request)
    {
        return Ok("Author updated!");
    }

    [HttpPost("Delete")]
    public async Task<IActionResult> DeleteAuthor(AuthorFindDeleteRequest request)
    {
        return Ok("Author deleted!");
    }
    
}