using Capstone.DAO;
using Capstone.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Capstone.Controllers
{
    [Route("[controller]")]
    [ApiController]

    public class MoviesController : ControllerBase
    {
        private readonly IMoviesSqlDao _moviesSqlDao;

        public MoviesController(IMoviesSqlDao moviesSqlDao)
        {
            _moviesSqlDao = moviesSqlDao;
        }

        [HttpPost]
        public IActionResult GetMovesByGeners(string[] genres)
        {
            return Ok( new List<Movie>( _moviesSqlDao.GetMoviesByGenre(genres)));
        }
        [HttpGet("{_name}")]
        public IActionResult GetMovieByName( string _name)
        {
            return Ok(_moviesSqlDao.GetMovieByName(_name));
        }
    }
}
