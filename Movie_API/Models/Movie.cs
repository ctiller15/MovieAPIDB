﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Movie_API.Models
{
    public class Movie
    {
        public int ID { get; set; }
        public string Title { get; set; }

        public int? GenreID { get; set; }
        public Genre Genre { get; set; }
        public int Rating { get; set; }
    }
}