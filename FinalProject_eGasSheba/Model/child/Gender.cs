using FinalProject_eGasSheba.Model.marketing;
using FinalProject_eGasSheba.Model.product;
using FinalProject_eGasSheba.Model.technician_Delivary;
using FinalProject_eGasSheba.Model.training;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace FinalProject_eGasSheba.Model.child
{
    public partial class Gender
    {
        
        public Gender()
        {
            this.customers = new HashSet<customer>();
            this.deliveryMen = new HashSet<deliveryMan>();
            this.technicians = new HashSet<technician>();
            this.Employees = new HashSet<employee>();
            this.Instructors= new HashSet<instructor>();    

        }
        [Key]
        public int Gid { get; set; }
        public string Gender_Name { get; set; }

       
        public virtual ICollection<customer>? customers { get; set; }
        public virtual ICollection<deliveryMan>? deliveryMen { get; set; }
        public virtual ICollection<technician>? technicians { get; set; }
        public virtual ICollection<employee>?  Employees { get; set; }
        public virtual ICollection<instructor>? Instructors { get; set; }    
    }
}
