using FinalProject_eGasSheba.Model.child;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FinalProject_eGasSheba.Model.services
{
    public class Appointment
    {
        [Key]
        public string Appointment_ID { get; set; }
        public string Customer_Name { get; set; }
        [ForeignKey("City")]
        public int City { get; set; }
        [ForeignKey("Area")]
        public int AreaID { get; set; }
        public string Road_NO { get; set; }
        public string House_No { get; set; }
        public string Floor_NO { get; set; }
        //[ForeignKey("Service")]
        //public string Service_ID { get; set; }
        //[ForeignKey("ProblemCategory")]
        //public string ProblemCat_ID { get; set; }
        //public string ProblemDescription { get; set; }
        public DateTime Date { get; set; }
        public string Phone { get; set; }
        [ForeignKey("PaymentTypes")]
        public int PaymentType_ID { get; set; }
        [ForeignKey("Condition")]
        public string Condition_ID { get; set; }
        //public Service Service { get; set; }
        //public ProblemCategory ProblemCategory { get; set; }
        public payment_type PaymentTypes { get; set; }
        public virtual Area Area { get; set; }
        public IList<Appointment_Details>? Appointment_Details { get; set; }

    }
}
