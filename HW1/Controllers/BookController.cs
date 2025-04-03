using Library.DTO.Requests.Book;
using Microsoft.AspNetCore.Mvc;

namespace Library.Controllers;

[ApiController]
[Route("api/[controller]")]
public class BookController: ControllerBase
{
    [HttpPost("Add")]
    public async Task<IActionResult>  AddBook(AddBookRequest request)
    {
        return Ok("Book added!");
    }

    [HttpPost("Update")]
    public async Task<IActionResult> UpdateBook(UpdateBookRequest request)
    {
        return Ok("Book updated!");
    }

    [HttpPost("Delete")]
    public async Task<IActionResult> DeleteBook(FindDeleteBookRequest request)
    {
        return Ok("Book deleted!");
    }
}