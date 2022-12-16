using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Capstone.Models
{
    public class Movie
    {
        public int Movie_id { get; set; }
        public string Title { get; set; }
        public string Overview { get; set; }
        public string TagLine { get; set; }
        public string Poster_path { get; set; }
        
        public DateTime ReleaseDat { get; set; }
        public int Length { get; set; }
    }
}
