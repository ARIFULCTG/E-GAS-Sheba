using FinalProject_eGasSheba.Model.marketing;
using FinalProject_eGasSheba.Model.product;
using FinalProject_eGasSheba.Model.puechase;
using FinalProject_eGasSheba.Model.sales;
using FinalProject_eGasSheba.Model.services;
using FinalProject_eGasSheba.Model.technician_Delivary;
using FinalProject_eGasSheba.Model.training;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace FinalProject_eGasSheba.Model.child
{
    public partial class City
    {
        
        public City()
        {
            this.appointments = new HashSet<Appointment>();
            this.appointmentApproveds = new HashSet<AppointmentApproval>();
            this.customers = new HashSet<customer>();
            this.deliveryMen = new HashSet<deliveryMan>();
            this.employees = new HashSet<employee>();
            this.instructors = new HashSet<instructor>();
            this.marktings = new HashSet<markting>();
            this.purchaseMasters = new HashSet<purchaseMaster>();
            this.purchaseOrderMasters = new HashSet<purchaseOrderMaster>();
            this.salesInvoiceMasters = new HashSet<salesInvoiceMaster>();
            this.salesMasters = new HashSet<salesMaster>();
            this.suppliers = new HashSet<supplier>();
            this.technicians = new HashSet<technician>();
        }
        [Key]
        public int cityID { get; set; }
        public string cityName { get; set; }

        public virtual ICollection<Appointment>? appointments { get; set; }
   
        public virtual ICollection<AppointmentApproval>? appointmentApproveds { get; set; }
       
        public virtual ICollection<customer>? customers { get; set; }
     
        public virtual ICollection<deliveryMan>? deliveryMen { get; set; }
      
        public virtual ICollection<employee>? employees { get; set; }
       
        public virtual ICollection<instructor>? instructors { get; set; }
        public virtual ICollection<markting>? marktings { get; set; }
        public virtual ICollection<purchaseMaster>? purchaseMasters { get; set; }
        public virtual ICollection<purchaseOrderMaster>? purchaseOrderMasters { get; set; }
        public virtual ICollection<salesInvoiceMaster>? salesInvoiceMasters { get; set; }
        public virtual ICollection<salesMaster>? salesMasters { get; set; }
        public virtual ICollection<supplier>? suppliers { get; set; }
        public virtual ICollection<technician>? technicians { get; set; }
    }
}
