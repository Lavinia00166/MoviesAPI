using Microsoft.AspNetCore.Mvc;
using MoviesAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace MoviesAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {

        private static List<Movie> movies = new List<Movie>()
        {
            new Movie() { Id = Guid.NewGuid(), Name = "Endless love", Budget = 150000000 },
            new Movie() { Id = Guid.NewGuid(), Name = "Love Rosie", Budget = 3000000},
            new Movie() { Id = Guid.NewGuid(), Name = "Me before you", Budget = 3240000},
            new Movie() { Id = Guid.NewGuid(), Name = "UP", Budget = 6800000}
        };

        [HttpGet]
        public Movie[] Get()
        {
            return movies.ToArray();
        }

        [HttpPost]
        public void Post([FromBody] Movie movie)
        {
            if (movie.Id == Guid.Empty)
                movie.Id = Guid.NewGuid();

            movies.Add(movie);
        }

        [HttpPut]
        public void Put([FromBody] Movie movie)
        {
            Movie currentMovie = movies.FirstOrDefault(m => m.Id == movie.Id);
            currentMovie.Name = movie.Name;
            currentMovie.Budget = movie.Budget;
           
        }

        [HttpDelete]
        public void Delete(Guid id)
        {
            movies.RemoveAll(movie => movie.Id == id);
        }
    }
}
