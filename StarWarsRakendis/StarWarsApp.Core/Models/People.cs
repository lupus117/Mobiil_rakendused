﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StarWarsApp.Core.Models
{
    public class PeopleDetails
    {
        public string name { get; set; }
        public string height { get; set; }
        public string mass { get; set; }
        public string hair_color { get; set; }
        public string skin_color { get; set; }
        public string eye_color { get; set; }
        public string birth_year { get; set; }
        public string gender { get; set; }
        public List<string> films { get; set; }
        public List<string> species { get; set; }
        public List<object> vehicles { get; set; }
        public List<string> starships { get; set; }
        public DateTime created { get; set; }
        public DateTime edited { get; set; }
        public string url { get; set; }
    }

    public class People
    {
        public int count { get; set; }
        public object next { get; set; }
        public object previous { get; set; }
        public List<PeopleDetails> results { get; set; }
    }
}