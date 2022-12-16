namespace Capstone.Models
{
    public class SeenMovie
    {
        /// <summary>
        /// class to hold all seen movies and if any is favorite
        /// </summary>
        public SeenMovie()
        {

        }
        public SeenMovie(string movieName, bool isFavorite)
        {
            MovieName = movieName;
            IsFavorite = isFavorite;
            //
        }
        public string MovieName { get; set; }
        public bool IsFavorite { get; set; }


    }
}