using System.Collections.Generic;

namespace Capstone.Models
{
    /// <summary>
    /// Class to hold user Profile data
    /// </summary>
    public class UserProfile
    {
        public UserProfile()
        {

        }
        public UserProfile(int userId, string aboutMe, List<SeenMovie> seenMovies, List<string> pickedGenres)
        {
            UserId = userId;
            AboutMe = aboutMe;
            SeenMovies = seenMovies;
            PickedGenres = pickedGenres;
        }
        public int UserId { get; set; }
        public string AboutMe { get; set; }
        public List<SeenMovie> SeenMovies { get; set; } = new List<SeenMovie>();
        public List<string> PickedGenres { get; set; } = new List<string>();

        //public void AddGenre(string generName) => PickedGenres.Add(generName);
        //public void AddMovie(string movieName, bool isSelect)
        //{
        //    SeenMovies.Add(new SeenMovie(movieName, isSelect));
        //}


        // TODO this class will have methods to trnasfer id to names and vice versa







    }
}
