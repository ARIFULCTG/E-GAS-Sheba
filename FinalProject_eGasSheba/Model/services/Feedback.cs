using FinalProject_eGasSheba.Model.technician_Delivary;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinalProject_eGasSheba.Model.services
{
    public class Feedback
    {
        [Key]
        public string Feedback_ID { get; set; }
        public string Feedback_Name { get; set; }
        public string Approval_ID { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public string Phone { get; set; }
        [ForeignKey("technician")]
        public int Technician_ID { get; set; }
        public IList<AppointmentApproval>? AppointmentApproval { get; set; }
        public IList<Approval_Details>? Approval_Details { get; set; }
        public technician technician { get; set; }  

    }
}
