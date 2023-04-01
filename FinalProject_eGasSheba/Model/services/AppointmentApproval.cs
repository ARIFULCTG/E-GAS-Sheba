using FinalProject_eGasSheba.Model.child;
using FinalProject_eGasSheba.Model.sales;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using FinalProject_eGasSheba.Model.technician_Delivary;

namespace FinalProject_eGasSheba.Model.services
{
    public class AppointmentApproval
    {
        [Key]
        public string Approval_ID { get; set; }
        [ForeignKey("technician")]
        public int Technician_ID { get; set; }
        public DateTime Date { get; set; }
        [ForeignKey("Appointment")]
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
        public Double Price { get; set; }
        [ForeignKey("PaymentTypes")]
        public int PaymentType_ID { get; set; }
        
       
        public double Discount { get; set; }
        public double netAmount { get; set; }
        public double paid { get; set; }
        public double due { get; set; }
        [ForeignKey("Feedback")]
        public string Feedback_ID { get; set; }
        //public Service Service { get; set; }
        //public ProblemCategory ProblemCategory { get; set; }
        public payment_type PaymentTypes { get; set; }
        public technician Technician { get; set; }
        public Feedback Feedback { get; set; }
        public  Area Area { get; set; }
        public IList<Approval_Details>? Approval_Details { get; set; }
        public IList<Invoice_Master>? Invoice_Master { get; set; }
        public IList<Invoice_Details_Product>? Invoice_Details_Product { get; set; }

    }
}
