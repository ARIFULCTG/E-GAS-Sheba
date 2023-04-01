using FinalProject_eGasSheba.Model.marketing;
using FinalProject_eGasSheba.Model.technician_Delivary;
using System.ComponentModel.DataAnnotations;

namespace FinalProject_eGasSheba.Model.product
{
    public partial class Experience
    {
        public Experience()
        {
            this.deliveryMen = new HashSet<deliveryMan>();
            this.technicians = new HashSet<technician>();
            this.Employees = new HashSet<employee>();
        }
        [Key]
        public int experienceID { get; set; }
        public Nullable<decimal> numerOfYear { get; set; }
        public string descriptions { get; set; }

        public virtual ICollection<deliveryMan>? deliveryMen { get; set; }
        public virtual ICollection<technician>? technicians { get; set; }
        public virtual ICollection<employee>? Employees { get; set; }
    }
}
