using System.ComponentModel.DataAnnotations;

namespace FinalProject_eGasSheba.Model.marketing
{
    public partial class designation
    {
        
        public designation()
        {
            this.employees = new HashSet<employee>();
        }
        [Key]
        public int designationID { get; set; }
        public string designationName { get; set; }

            
        public virtual ICollection<employee>? employees { get; set; }
    }
}
