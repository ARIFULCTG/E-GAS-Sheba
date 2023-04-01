using FinalProject_eGasSheba.Model.child;
using FinalProject_eGasSheba.Model.product;
using FinalProject_eGasSheba.Model.services;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection;
using Type = FinalProject_eGasSheba.Model.child.Type;

namespace FinalProject_eGasSheba.Model.technician_Delivary
{
    public partial class technician
    {
        
        public technician()
        {
            this.appointmentApproveds = new HashSet<AppointmentApproval>();
            this.Feedback = new HashSet<Feedback>();
            this.Invoice_Master = new HashSet<Invoice_Master>();
        }
        [Key]
        public int technicianID { get; set; }
        public string technicianName { get; set; }
        [ForeignKey("Gender")]
        public int Gid { get; set; }
        public string phone_01 { get; set; }
        public string phone_02 { get; set; }
        public string email { get; set; }
        [ForeignKey("City")]
        public int cityID { get; set; }
        [ForeignKey("Area")]
        public int aID { get; set; }
        public string road_No { get; set; }
        public string house_No { get; set; }
        public int technician_Type { get; set; }
        public Nullable<int> experienceID { get; set; }
        [ForeignKey("Condition")]
        public int coID { get; set; }
        public string photo { get; set; }

       
        public virtual ICollection<AppointmentApproval>? appointmentApproveds { get; set; }
        public virtual ICollection<Feedback>? Feedback { get; set; }
        public virtual ICollection<Invoice_Master>? Invoice_Master { get; set; }
        public virtual Area Area { get; set; }

        public virtual City City { get; set; }
        public virtual Condition Condition { get; set; }
        public virtual Experience Experience { get; set; }
        public virtual Gender Gender { get; set; }
        public virtual Type Type { get; set; }
    }
}
