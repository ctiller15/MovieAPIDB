using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using Movie_API.Data;
using Movie_API.Models;

namespace Movie_API.Controllers
{
    public class MoviesController : ApiController
    {
        public IEnumerable<Movie> Get()
        {
            //return new List<string> { "Die Hard", "Speed Racer", "The Nightmare before christmas", "Bee Movie" };
            var db = new MoviesContext();
            return db.Movies.ToList();
        }

        public IEnumerable<Movie> Get(string genre)
        {
            var db = new MoviesContext();
            return db.Movies.Where(x => x.Genre == genre).ToList();
        }

        public IHttpActionResult Post(string name)
        {
            var newMovie = new Movie
            {
                Title = name
            };
            var db = new MoviesContext();
            db.Movies.Add(newMovie);
            db.SaveChanges();
            return Ok(newMovie);
        }
    }
}
