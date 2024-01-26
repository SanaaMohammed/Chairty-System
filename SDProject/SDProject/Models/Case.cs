using Microsoft.EntityFrameworkCore;
using SDProject.Data.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SDProject.Models
{
    public class Case
    {
        [Key]
        [Display(Name = "Case Id")]
        public int CaseId { get; set; }
        [Required(ErrorMessage ="You must enter a first name.")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "You must enter a last name.")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "You must enter an address.")]
        [Display(Name ="Case Address")]
        public string Address { get; set; }
        [Required(ErrorMessage = "You must enter the family size.")]
        public int FamilySize { get; set; }
        [Required(ErrorMessage = "You must the age of the case.")]
        [Display(Name = "Age")]
        public int Age { get; set; }
        public Gender CaseGender { get; set; }
        [Required(ErrorMessage = "You must enter a phone number.")]
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage ="You've to enter the monthly earning of the case.")]
        public float MonthlyEarnings { get; set; }
        public string Dieseases { get; set; }
        public string GeneralNotes { get; set; }

        // Relations:
        // Each case have only one inspector.
        public virtual int InspectorId { get; set; }
        public virtual CaseInspector? Inspector { get; set; }
        // Each case have can have many reports.
        public virtual ICollection<Report>? MyReports { get; set; }
    }
}
