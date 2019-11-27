using System.ComponentModel.DataAnnotations;

namespace form_submission.Models
{
    public class User
    {
        [Required]
        [MinLength(4)]
        public string firstName { get; set; }
        [Required]
        [MinLength(4)]
        public string lastName { get; set; }
        [Required]
        [Range(0,100)]
        public string age { get; set; }
        [Required]
        [EmailAddress]
        public string email { get; set; }
        [Required]
        [MinLength(8)]
        [DataType(DataType.Password)]
        public string password { get; set; }
        
    }
}