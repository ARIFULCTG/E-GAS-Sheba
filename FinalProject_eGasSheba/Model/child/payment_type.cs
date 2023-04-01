using FinalProject_eGasSheba.Model.puechase;
using FinalProject_eGasSheba.Model.sales;
using FinalProject_eGasSheba.Model.services;
using System.ComponentModel.DataAnnotations;

namespace FinalProject_eGasSheba.Model.child
{
    public partial class payment_type
    {
            
        public payment_type()
        {
            this.appointmentApproveds = new HashSet<AppointmentApproval>();
            this.salesInvoiceMasters = new HashSet<salesInvoiceMaster>();
            this.salesMastersMasters = new HashSet<salesMaster>();
            this.PurchaseMasters = new HashSet<purchaseMaster>();
        }
        [Key]
        public int paymentID { get; set; }
        public string paymentName { get; set; }

        public virtual ICollection<AppointmentApproval>? appointmentApproveds { get; set; }
        public virtual ICollection<salesInvoiceMaster>? salesInvoiceMasters { get; set; }
        public virtual ICollection<salesMaster>? salesMastersMasters { get;set; }
        public virtual ICollection<purchaseMaster>? PurchaseMasters { get; set; }
    }
}
