using SDProject.Data.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SDProject.Models
{
    public class Report
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ReportId { get; set; }

        [Required(ErrorMessage ="Please choose if the data is valid or not.")]
        public bool IfDataValid { get; set; }


        [Required(ErrorMessage ="Enter the type of case.")] 
        public CaseType TypeOfCase { get; set; }


        [Required(ErrorMessage ="The final conclusion is required.")]
        public string FinalConclusion { get; set; }

        // Relations:
            // Each report can have only one case.
        public virtual int CaseId { get; set; }
        public virtual Case? MyCase { get; set; }
    }
}
