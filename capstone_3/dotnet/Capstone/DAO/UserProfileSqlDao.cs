using Capstone.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Transactions;
using Microsoft.AspNetCore.Http;
using ShredClasses;

namespace Capstone.DAO
{
    public class UserProfileSqlDao : IUserProfileDao
    {

        private readonly string connectionString;
        public UserProfileSqlDao(string dbConnectionString)
        {
            connectionString = dbConnectionString;
        }

        // Helper function
        public string GetGenreNameById(int id)
        {
            string result;
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    {
                        SqlCommand cmd = new SqlCommand("GetGenreNameById", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id", id);
                        SqlDataReader reader = cmd.ExecuteReader();
                        reader.Read();
                        result = Convert.ToString(reader["genre_name"]);
                    }
                }
            }
            catch (SqlException)
            {
                throw;
            }
            return result;

        }
        public string GetMovieNameById(int id)
        {
            string result;
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    {
                        SqlCommand cmd = new SqlCommand("GetMovieNameById", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id", id);
                        SqlDataReader reader = cmd.ExecuteReader();
                        reader.Read();
                        result = Convert.ToString(reader["title"]);
                    }
                }
            }
            catch (SqlException)
            {
                throw;
            }
            return result;

        }

        public void  CreateUserProfile(UserProfile profile)
        {
            InsertUserProfile(profile.AboutMe, profile.UserId);
            InsertMovie(MoviesToIds(profile.SeenMovies), profile.UserId);
            InsertGenres(GenreToIds(profile.PickedGenres), profile.UserId);

        }
        public UserProfile GetUserProfile(int id)
        {
            UserProfile profile = new UserProfile();
            profile.UserId = id;
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("SELECT about_me  FROM  user_profile  WHERE user_id =  @userId ;");
                    cmd.Connection = conn;
                    cmd.Parameters.AddWithValue("@userId", id);

                    SqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();
                    if (reader.HasRows)
                    {
                        profile.AboutMe = Convert.ToString(reader["about_me"]);
                    }
                    else
                    {
                        profile.AboutMe = "";
                    }
                    
                    reader.Close();

                    cmd.CommandText = "SELECT genre_id FROM user_favorite_genres WHERE user_id =@userId ;";

                    reader = cmd.ExecuteReader();
                    profile.PickedGenres = new List<string>();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            profile.PickedGenres.Add((Convert.ToInt16(reader["genre_id"])).ToString());
                        }
                    }
                    reader.Close();

                    //  Convert genre Id  to name

                    for (int i = 0; i < profile.PickedGenres.Count; i++)
                    {
                        profile.PickedGenres[i] = GetGenreNameById(int.Parse(profile.PickedGenres[i]));
                    }

                    cmd.CommandText = "SELECT seen_movies ,favorite_movies  FROM user_movies where user_id =@userId ;";

                    reader = cmd.ExecuteReader();
                    profile.SeenMovies = new List<SeenMovie>();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            profile.SeenMovies.Add(
                                new SeenMovie(
                                    (Convert.ToInt16(reader["seen_movies"])).ToString(),
                                        Convert.ToBoolean(reader["favorite_movies"])));
                        }
                    }

                    reader.Close();

                    for (int i = 0; i < profile.SeenMovies.Count; i++)
                    {
                        profile.SeenMovies[i].MovieName = GetMovieNameById(int.Parse(profile.SeenMovies[i].MovieName));
                    }
                }
            }
            catch (SqlException)
            {
                throw;
            }
            return profile;
        }

        /// <summary>
        /// transfer a list of movies name to list of movies id 
        ///   Armageddon      >  95
        //    The green Mile  >  497
        //    The sixth Sense >  745
        /// </summary>
        /// <param name="movies"></param>
        /// <returns></returns>
        public List<SeenMovie> MoviesToIds(List<SeenMovie> movies)
        {
            List<SeenMovie> result = new List<SeenMovie>();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    foreach (var item in movies)
                    {

                        SqlCommand cmd = new SqlCommand("SELECT movie_id FROM movie where title  = @moviename", conn);
                        cmd.Parameters.AddWithValue("@moviename", item.MovieName);
                        SqlDataReader reader = cmd.ExecuteReader();
                        reader.Read();
                        int movieId = Convert.ToInt32(reader["movie_id"]);
                        reader.Close();
                        result.Add(
                            new SeenMovie(movieId.ToString(), item.IsFavorite)
                            );
                    }
                }

            }
            catch (SqlException)
            {
                throw;
            }
            return result;

        }
        /// <summary>
        /// transfer a list of genres  name to list of genres with id 
        ///   Thriller      >  53
        //    Adventure     >  12
        //    Action        >  28
        /// </summary>
        /// <param name="genres"></param>
        /// <returns></returns>
        public List<string> GenreToIds(List<string> genres)
        {
            List<string> result = new List<string>();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    foreach (var item in genres)
                    {
                        SqlCommand cmd = new SqlCommand("SELECT genre_id FROM genre where genre_name = @genrename", conn);
                        cmd.Parameters.AddWithValue("@genrename", item);
                        SqlDataReader reader = cmd.ExecuteReader();
                        reader.Read();
                        int genreID = Convert.ToInt32(reader["genre_id"]);
                        reader.Close();

                        result.Add(genreID.ToString());
                    }
                }

            }
            catch (SqlException)
            {
                throw;
            }
            return result;

        }
        public bool InsertUserProfile(string aboutMe, int userId)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    //SqlCommand cmd = new SqlCommand("BEGIN TRANSACTION;",conn);
                    //  cmd.ExecuteNonQuery();

                    SqlCommand cmd = new SqlCommand("INSERT INTO user_profile  (about_me,user_id) VALUES (@aboutMe , @userId);", conn);
                    cmd.Parameters.AddWithValue("@aboutMe", aboutMe);
                    cmd.Parameters.AddWithValue("@userId", userId);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException)
            {
                return false;
            }
            return true;
        }
        public bool InsertMovie(List<SeenMovie> movies, int userId)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "INSERT INTO user_movies(user_id, seen_movies, favorite_movies) " +
                                                         "VALUES (@userId,@seen_movies_id,@favorite_movies);";
                        cmd.Parameters.Add(new SqlParameter("@userId", SqlDbType.Int));
                        cmd.Parameters.Add(new SqlParameter("@seen_movies_id", SqlDbType.Int));
                        cmd.Parameters.Add(new SqlParameter("@favorite_movies", SqlDbType.Bit));

                        cmd.Parameters[0].Value = userId;
                        foreach (var item in movies)
                        {
                            cmd.Parameters[1].Value = int.Parse(item.MovieName);
                            cmd.Parameters[2].Value = item.IsFavorite;
                            cmd.ExecuteNonQuery();
                        }
                    }
                }
            }
            catch (SqlException)
            {
                return false;
            }
            return true;
        }
        public bool InsertGenres(List<string> Genres, int userId)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "INSERT INTO user_favorite_genres (user_id, genre_id) " +
                                                         "VALUES(@userId,@pickedGenre );";
                        cmd.Parameters.Add(new SqlParameter("@userId", SqlDbType.Int));
                        cmd.Parameters.Add(new SqlParameter("@pickedGenre", SqlDbType.Int));

                        cmd.Parameters[0].Value = userId;
                        foreach (var item in Genres)
                        {

                            {
                                cmd.Parameters[1].Value = int.Parse(item);
                                cmd.ExecuteNonQuery();
                            }
                        }
                    }
                }
            }
            catch (SqlException)
            {
                return false;
            }
            return true;
        }
        public bool DeleteUserProfile(int id)
        {

            ///// remove this
            return true;



          

            using (TransactionScope scop = new TransactionScope())
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        SqlCommand cmd = conn.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "DELETE FROM user_movies WHERE user_id= @userId ; " +
                            "DELETE FROM user_favorite_genres WHERE user_id =@userId ; " +
                            "DELETE FROM user_profile WHERE user_id= @userId;";
                        // "DELETE FROM users WHERE user_id= @userId;";             You need to add this to delete user as well
                        cmd.Parameters.AddWithValue("@userId", id);
                        cmd.ExecuteNonQuery();
                    }
                    scop.Complete();
                }
                catch (SqlException)
                {
                    return false;
                }
            }

            return true;
        }

        public bool UpdateProfile(UserProfile profile)
        {
            DeleteUserProfile(profile.UserId);
            CreateUserProfile(profile);
            return true;
        }
    }
}
