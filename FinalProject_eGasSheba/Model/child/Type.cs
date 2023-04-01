using FinalProject_eGasSheba.Model.product;
using FinalProject_eGasSheba.Model.puechase;
using FinalProject_eGasSheba.Model.technician_Delivary;
using System.ComponentModel.DataAnnotations;

namespace FinalProject_eGasSheba.Model.child
{
    public partial class Type
    {
        
        public Type()
        {
            this.customers = new HashSet<customer>();
            this.products = new HashSet<product>();
            this.suppliers = new HashSet<supplier>();
            this.technicians = new HashSet<technician>();
        }
        [Key]
        public int tID { get; set; }
        public string typeName { get; set; }

        
        public virtual ICollection<customer>? customers { get; set; }
        
        public virtual ICollection<product>? products { get; set; }
        public virtual ICollection<supplier>? suppliers { get; set; }
        public virtual ICollection<technician>? technicians { get; set; }
    }
}
