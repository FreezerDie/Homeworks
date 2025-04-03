using Library.Data.Models;
using Library.DTO.Requests.Genre;
using Microsoft.AspNetCore.Mvc;

namespace Library.Controllers;
[ApiController]
[Route("api/[controller]")]
public class GenreController : ControllerBase
{
    [HttpPost("Add")]
    public IActionResult AddGenre(AddGenreRequest request)
    {
        return Ok("Genre added");
    }

    [HttpPost("Update")]
    public IActionResult UpdateGenre(UpdateGenreRequest request)
    {
        return Ok("Genre updated");
    }

    [HttpPost("Delete")]
    public IActionResult DeleteGenre(FindDeleteGenreRequest request)
    {
        return Ok("Genre deleted");
    }
}