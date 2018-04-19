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
            return db.Movies.Where(x => x.Genre.Name == genre).ToList();
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

        public IHttpActionResult Put(int ID, [FromBody]Dictionary<string, string> dict)
        {
            var db = new MoviesContext();
            var movieToUpdate = db.Movies.First(x => x.ID == ID);
            //foreach(var item in dict)
            //{
            //    Console.WriteLine(item);
            //}
            movieToUpdate.Title = dict["Title"];
            movieToUpdate.Rating = Convert.ToInt32(dict["Rating"]);
            var newGenre = dict["Genre"];
            var usedGenre = db.Genres.First(x => x.Name == newGenre);
            //var newGenre = new Models.Genre()
            //{
            //    Name = dict["Genre"]
            //};
            //movieToUpdate.Genre = newGenre;
            //movieToUpdate.Title = object.Title;
            //movieToUpdate.Rating = movie.Rating;
            //movieToUpdate.Genre.Name = GenreName;
            db.SaveChanges();
            return Ok(movieToUpdate);
        }
    }
}
