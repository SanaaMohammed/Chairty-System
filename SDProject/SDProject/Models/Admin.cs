using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SDProject.Models
{
    public class Admin
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required(ErrorMessage ="You must enter a name.")]
        public string Name { get; set; }
        [Required(ErrorMessage ="You must enter an Email.")]
        [EmailAddress]
        public string Email { get; set; }
        [Required(ErrorMessage ="You must enter a password.")] 
        public string Password { get; set; }
        [Required]
        [Compare("Password", ErrorMessage = "Not Match")]
        public string ConfirmPassword { get; set; }
    }
}
