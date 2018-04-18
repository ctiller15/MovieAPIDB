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
    public class SearchController : ApiController
    {
        public IEnumerable<Movie> Get(string name)
        {
            var db = new MoviesContext();
            return db.Movies.Where(x => x.Title.Contains(name)).ToList();
        }

    }
}
