using FinalProject_eGasSheba.Model.training;
using System.ComponentModel.DataAnnotations;

namespace FinalProject_eGasSheba.Model.marketing
{
    public partial class educationQualification
    {
        
        public educationQualification()
        {
            this.employees = new HashSet<employee>();
            this.instructors = new HashSet<instructor>();
        }
        [Key]
        public int eduQualificationID { get; set; }
        public string qualificationName { get; set; }

        public virtual ICollection<employee>? employees { get; set; }
        
        public virtual ICollection<instructor>? instructors { get; set; }
    }
}
