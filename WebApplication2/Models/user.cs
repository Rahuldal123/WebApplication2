using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class user
    {

        [Required(ErrorMessage ="Name is required")]
        [MaxLength(60,ErrorMessage ="Name must have less than 60 characters")]
        public string? Name { get; set; }

        [Required(ErrorMessage ="Email Id is Required")]
        [DataType(DataType.EmailAddress,ErrorMessage ="Email is required")]
        public string? Email { get; set; }
        [Required (ErrorMessage ="Age is required")]
        [Range(18,60,ErrorMessage ="Age Must be in between 18 to 60")]
        public int age { get; set; }
        [Required (ErrorMessage ="password is Required")]
        [DataType(DataType.Password)]
        public int Password { get; set; }
    }
}
