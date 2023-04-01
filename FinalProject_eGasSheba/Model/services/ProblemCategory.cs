using FinalProject_eGasSheba.Model.sales;
using System.ComponentModel.DataAnnotations;

namespace FinalProject_eGasSheba.Model.services
{
    public class ProblemCategory
    {
        [Key]
        public string ProblemCat_ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public IList<Appointment>? Appointment { get; set; }
        public IList<Appointment_Details>? Appointment_Details { get; set; }
        public IList<Approval_Details>? Approval_Details { get; set; }
        public IList<AppointmentApproval>? AppointmentApproval { get; set; }
        public IList<Invoice_Master>? Invoice_Master { get; set; }
        public IList<Invoice_Details_Product>? Invoice_Details_Product { get; set; }

    }
}
