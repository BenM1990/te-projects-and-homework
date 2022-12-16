namespace Capstone.Models
{
    public class ChosenMovie
    {
        public int MovieId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool Seen { get; set; }
        public bool Interested { get; set; }
        public bool Liked { get; set; }
        public string Picture { get; set; }

    }
}