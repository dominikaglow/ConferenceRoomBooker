using System.ComponentModel.DataAnnotations;

namespace WebAPI.Model
{
    public class User
    {
        public long Id { get; set; }
        [Required]
        [MinLength(5, ErrorMessage ="Username must be at least 5 characters long")]
        public string Username { get; set; }
        [Required]
        [MinLength(7, ErrorMessage = "Password must be at least 7 characters long")]
        public int Password { get; set; }
        [Required]
        public string CompanyName { get; set; }
        [Required]
        public string Email { get; set; }
    }
}
