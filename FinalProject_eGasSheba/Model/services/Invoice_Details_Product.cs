using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FinalProject_eGasSheba.Model.services
{
    public class Invoice_Details_Product
    {
        
        public string Vo_No { get; set; }
       
        public string SI_No { get; set; }
        [ForeignKey("Invoice_Master")]
        public string InvoiceMaster_ID { get; set; }
        [ForeignKey("Product")]
        public string Product_ID { get; set; }
        [ForeignKey("AppointmentApproval")]
        public string Approval_ID { get; set; }
        [ForeignKey("Service")]
        public string Service_ID { get; set; }
        [ForeignKey("ProblemCategory")]
        public string ProblemCat_ID { get; set; }
        public string Price { get; set; }
        public Invoice_Master Invoice_Master { get; set; }

    }
}
