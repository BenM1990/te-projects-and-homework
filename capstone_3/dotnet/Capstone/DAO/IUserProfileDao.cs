using Capstone.Models;
using System.Collections.Generic;

namespace Capstone.DAO
{
    public interface IUserProfileDao
    {
        UserProfile GetUserProfile(int id);
        bool DeleteUserProfile(int id);



        List<SeenMovie> MoviesToIds(List<SeenMovie> movies);
        List<string> GenreToIds(List<string> genres);

        bool UpdateProfile(UserProfile profile);



    

        //-------  Create User profile  >>> about Me
         void CreateUserProfile(UserProfile profile);

        bool InsertUserProfile(string aboutMe, int userId);

        
        //-------  Create Movies Data  >>> Insert SeenMovies List
        bool InsertMovie(List<SeenMovie> Movies, int userId);
       
        
        //-------  Create Genres data  >>> insert Picked List
        bool InsertGenres(List<string> Genres, int userId);







    }
}
