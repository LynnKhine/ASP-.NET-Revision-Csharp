using APItest.Entities;
using APItest.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using APItest.Models.Movie;

namespace APItest.Controllers;

    [ApiController]
    [Route("api/[controller]")]
public class MovieController : Controller
{
    private readonly AppDbContext _context;


    public MovieController(AppDbContext context)
    {
        _context = context;
    }

    [HttpPost]
    [Route("CreateMovie")]
    public IActionResult CreateMovie(CreateMovieRequestModel request)
    {


        MovieEntity movie = new MovieEntity()
        {
            Id = request.Id,
            Title = request.Title,
            Genre = request.Genre,
            ReleaseDate = DateTime.Now
        };

        _context.MovieDbSet.Add(movie);
        _context.SaveChanges();

        
        return Ok();
    }

    [HttpGet]
    [Route("GetMovieById")]
    public IActionResult GetMovieById(int id)
    {
        var response = _context.MovieDbSet.Where(m => m.Id == id).FirstOrDefault();

        return Ok(response);
    }


    [HttpPost]
    [Route("GetMovieList")]
    public IActionResult GetMovieList()
    {
        var response = _context.MovieDbSet.ToList();

        return Ok(response);
    }

    [HttpGet]
    [Route("DeleteMovieById")]
    public IActionResult DeleteMovieById(int id)
    {
        var movie = _context.MovieDbSet.Where(m => m.Id == id).FirstOrDefault();

        _context.MovieDbSet.Remove(movie);
        _context.SaveChanges();

        return Ok(movie);
    }

    [HttpGet]
    [Route("UpdateMovie")]
    public IActionResult UpdateMovie(int id, string title, string genre, DateTime releaseDate)
    {
        MovieEntity movie = _context.MovieDbSet.Where(m => m.Id == id).FirstOrDefault();

        movie.Title = title;
        movie.Genre = genre;
        movie.ReleaseDate = releaseDate;

        _context.MovieDbSet.Update(movie);
        _context.SaveChanges();

        return Ok(movie);
    }

}
