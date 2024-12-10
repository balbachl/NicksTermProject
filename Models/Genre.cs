namespace TermProject.Models
{
    public class Genre
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public ICollection<MovieReview> MovieReviews { get; set; } = new List<MovieReview>();
    }
}