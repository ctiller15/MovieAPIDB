using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using Movie_API.Models;
using Movie_API.Data;

namespace Movie_API.Controllers
{
    public class MovieUpdateController : ApiController
    {
        public IHttpActionResult Put(int ID, [FromBody]Movie movie)
        {
            var db = new MoviesContext();
            var movieToUpdate = db.Movies.First(x => x.ID == ID);
            movieToUpdate.Title = movie.Title;
            movieToUpdate.Rating = movie.Rating;
            movieToUpdate.Genre = movie.Genre;
            db.SaveChanges();
            return Ok(movieToUpdate);
        }
    }
}
