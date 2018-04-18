using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Movie_API.Data
{
    public class MoviesContext:DbContext
    {
        public MoviesContext():base("name=DefaultConnection")
        {

        }

        public DbSet<Models.Movie> Movies { get; set; }
    }
}