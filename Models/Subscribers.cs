using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TermProject.Models
{
    public enum Gender
    {
        Male,
        Female,
        Other
    }

    public class Subscribers
    {
        public int ID { get; set; }

        [Required]
        [StringLength(30, ErrorMessage = "First name is required.")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; } = string.Empty;

        [Required]
        [StringLength(30, ErrorMessage = "Last name is required.")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; } = string.Empty;

        [Display(Name = "Gender")]
        public Gender? GenderIdentity { get; set; }

        [StringLength(50, ErrorMessage = "Please enter a valid address.")]
        public string? Address { get; set; } = string.Empty;

        [StringLength(30, ErrorMessage = "Please enter a valid city.")]
        public string? City { get; set; } = string.Empty;

        [StringLength(2, ErrorMessage ="Please enter an abbreviated state.")]
        public string? State { get; set; } = string.Empty;

        [StringLength(10, ErrorMessage ="Please enter a valid zip code.")]
        public string? Zip {  get; set; } = string.Empty;

        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        [Column("Subscriber_Email")]

        public string email {  get; set; } = string.Empty;
       
        [Display(Name = "Phone Number")]
        public string? phoneNumber { get; set; } = string.Empty;

        public ICollection<MovieReview> MovieReviews { get; set; } = new List<MovieReview>();

    }
}
