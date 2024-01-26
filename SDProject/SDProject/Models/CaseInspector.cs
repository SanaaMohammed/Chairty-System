using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace SDProject.Models
{
    public class CaseInspector
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int InspectorId { get; set; }
        [Required(ErrorMessage ="You must enter the name of the inspector.")]
        public string Name { get; set; }
        
        [Required(ErrorMessage ="You must enter your email.")]
        [EmailAddress]
        public string Email{ get; set; }
        [Required(ErrorMessage ="You must enter a password.")]
        public string Password { get; set; }
        [Required(ErrorMessage = "You must enter the salary.")]
        public float Salary{ get; set; }
        // Image attribute
        [AllowNull]
        public byte[] ImageData { get; set; }
        // Relations:
        public virtual ICollection<Case>? Cases { get; set; }
    }
}