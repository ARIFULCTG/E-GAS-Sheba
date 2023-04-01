using FinalProject_eGasSheba.Model.child;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FinalProject_eGasSheba.Model.services
{
    public class Approval_Details
    {
       
        public string Vo_No { get; set; }
       
        public string SI_No { get; set; }
        [ForeignKey("AppointmentApproval")]
        public string Approval_ID { get; set; }
        [ForeignKey("Service")]
        public string Service_ID { get; set; }
        [ForeignKey("ProblemCategory")]
        public string ProblemCat_ID { get; set; }
        //[ForeignKey("PaymentTypes")]
        //public string PaymentType_ID { get; set; }
        [ForeignKey("Feedback")]
        public string Feedback_ID { get; set; }
        //public DateTime Date { get; set; }
        public Double Price { get; set; }
        public Service Service { get; set; }
        public ProblemCategory ProblemCategory { get; set; }
        //public payment_type PaymentTypes { get; set; }
        public AppointmentApproval AppointmentApproval { get; set; }


    }
}
