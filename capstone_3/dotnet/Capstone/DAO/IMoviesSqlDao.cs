using Capstone.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Capstone.DAO
{
   public interface IMoviesSqlDao
    {
        List<Movie> GetMoviesByGenre(string[] genres);
        Movie GetMovieByName(string _name);
    
    }
}
