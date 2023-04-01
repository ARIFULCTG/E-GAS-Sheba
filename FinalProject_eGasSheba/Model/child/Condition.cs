using FinalProject_eGasSheba.Model.puechase;
using FinalProject_eGasSheba.Model.technician_Delivary;
using System.ComponentModel.DataAnnotations;

namespace FinalProject_eGasSheba.Model.child
{
    public partial class Condition
    {
        
        public Condition()
        {
            this.deliveryMen = new HashSet<deliveryMan>();
            this.purchaseMasters = new HashSet<purchaseMaster>();
            this.purchaseOrderMasters = new HashSet<purchaseOrderMaster>();
            this.suppliers = new HashSet<supplier>();
            this.technicians = new HashSet<technician>();
        }
        [Key]
        public int coID { get; set; }
        public string conditionName { get; set; }
        public string Detail { get; set; }

        
        public virtual ICollection<deliveryMan>? deliveryMen { get; set; }
        public virtual ICollection<purchaseMaster>? purchaseMasters { get; set; }
        public virtual ICollection<purchaseOrderMaster>? purchaseOrderMasters { get; set; }
        public virtual ICollection<supplier>? suppliers { get; set; }
        public virtual ICollection<technician>? technicians { get; set; }
    }
}
