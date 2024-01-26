using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SDProject.Models
{
    public class Login
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "You must enter an Email.")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "You must enter a password.")]
        public string Password { get; set; }
    }
}
