using System.Collections.Generic;

namespace TermProject.Models
{
    public class DashboardViewModel
    {
        public IEnumerable<MovieReview> MovieReviews { get; set; } = Enumerable.Empty<MovieReview>();
        public IEnumerable<Genre> Genres { get; set; } = Enumerable.Empty<Genre>();
    }
}