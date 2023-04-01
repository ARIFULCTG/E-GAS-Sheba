using System.ComponentModel.DataAnnotations;

namespace FinalProject_eGasSheba.Model.marketing
{
    public partial class empDepartment
    {
        public empDepartment()
        {
            this.employees = new HashSet<employee>();
        }
        [Key]
        public int empDepID { get; set; }
        public string depName { get; set; }

        public virtual ICollection<employee>? employees { get; set; }
    }
}
