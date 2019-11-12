﻿using System;
using System.Collections.Generic;
using System.Text;

namespace StarWarsApp.Core.Models
{
    public class MoviesDetails
    {
        public string title { get; set; }
        public int episode_id { get; set; }
        public string opening_crawl { get; set; }
        public string director { get; set; }
        public string producer { get; set; }
        public string release_date { get; set; }
        public List<string> characters { get; set; }
        public List<string> planets { get; set; }
        public List<string> starships { get; set; }
        public List<string> vehicles { get; set; }
        public List<string> species { get; set; }
        public DateTime created { get; set; }
        public DateTime edited { get; set; }
        public string url { get; set; }
    }  

    public class Movies
    {
        public int count { get; set; }
        public object next { get; set; }
        public object previous { get; set; }
        public List<MoviesDetails> results { get; set; }
    }
}
