using Movie_API.Models;
using Movie_API.Data;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Movie_API.Controllers
{
    public class MovieFactoryController : ApiController
    {
        public IHttpActionResult Post(Movie data)
        {
            var db = new MoviesContext();
            db.Movies.Add(data);
            db.SaveChanges();
            return Ok(data);
        }
    }
}
