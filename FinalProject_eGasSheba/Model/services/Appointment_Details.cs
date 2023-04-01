using FinalProject_eGasSheba.Model.child;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FinalProject_eGasSheba.Model.services
{
    public class Appointment_Details
    {
       
        public string Vo_No { get; set; }
      
        public string SI_No { get; set; }
        [ForeignKey("Appointment")]
        public string Appointment_ID { get; set; }
        [ForeignKey("Service")]
        public string Service_ID { get; set; }
        [ForeignKey("ProblemCategory")]
        public string ProblemCat_ID { get; set; }
        public string ProblemDescription { get; set; }
        //[ForeignKey("PaymentTypes")]
        //public string PaymentType_ID { get; set; }
        //[ForeignKey("Condition")]
        //public string Condition_ID { get; set; }
        ////public DateTime Date { get; set; }
        //public string Phone { get; set; }
        public Service Service { get; set; }
        //public Condition Condition { get; set; }
        public ProblemCategory ProblemCategory { get; set; }
        //public payment_type PaymentTypes { get; set; }
        public Appointment Appointment { get; set; }

    }
}
