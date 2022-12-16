using Capstone.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Capstone.DAO
{
    public class MoviesSqlDao : IMoviesSqlDao
    {

        private readonly string connectionString;
        public MoviesSqlDao(string dbConnectionString)
        {
            connectionString = dbConnectionString;
        }

        public Movie GetMovieByName(string _name)
        {
            Movie result = new Movie() ;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM movie WHERE title = @title", conn);

                    cmd.Parameters.AddWithValue("@title", _name);


                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        result = GetMovieFromReader(reader);
                    }
                    
                }
            }
            catch (SqlException)
            {
                result = null;
                throw;
            }
            return result;









        }

        public List<Movie> GetMoviesByGenre(string[] genres = null)
        {
            List<Movie> result = null;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand
                    {
                        Connection = conn
                    };
                    if (genres.Length > 0)
                    {
                        cmd.CommandText = $"SELECT DISTINCT movie.* FROM movie JOIN movie_genre ON movie.movie_id = movie_genre.movie_id JOIN genre ON genre.genre_id = movie_genre.genre_id WHERE genre.genre_name IN  ({CreateListOfgenres(genres)})";
                    }
                    else
                    {
                        cmd.CommandText = "SELECT * FROM movie";
                    }

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {                      
                        result = new List<Movie>();
                    }
                    while (reader.Read())
                    {
                        var _movie = GetMovieFromReader(reader);
                        result.Add(_movie);
                    }
                }
            }
            catch (SqlException)
            {
                result = null;
                throw;
            }
          return result ;
        }
        private string CreateListOfgenres(string[] str)
        {
            string[] result = new string[str.Length];

            for (int i = 0; i < str.Length; i++)
            {
                result[i] = "'" + str[i] + "'";
            }

            return string.Join(" , ", result);
        }
        private Movie GetMovieFromReader(SqlDataReader reader)
        {
            Movie movie = new Movie()
            {
                Movie_id = Convert.ToInt32(reader["movie_id"]),
                Title = Convert.ToString(reader["title"]),
                Overview = Convert.ToString(reader["overview"]),
                TagLine = Convert.ToString(reader["tagline"]),
                Poster_path = Convert.ToString(reader["poster_path"]),
                ReleaseDat = Convert.ToDateTime(reader["release_date"]),
                Length = Convert.ToInt32(reader["length_minutes"]),
            };
            return movie;
        }
    }
}
