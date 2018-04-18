using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Movie_API.Controllers
{
    public class MoviesController : ApiController
    {
        public IEnumerable<String> Get()
        {
            return new List<string> { "Die Hard", "Speed Racer", "The Nightmare before christmas", "Bee Movie" };
        }
    }
}
