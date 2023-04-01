using FinalProject_eGasSheba.Model.sales;
using System.ComponentModel.DataAnnotations;

namespace FinalProject_eGasSheba.Model.services
{
    public class Service
    {
        [Key]
        public string Service_ID { get; set; }
        public string ServiceName { get; set; }
        public string Service_Fee { get; set; }
        public string Fee { get; set; }
        public IList<Appointment>? Appointment { get; set; }
        public IList<Appointment_Details>? Appointment_Details { get; set; }
        public IList<Approval_Details>? Approval_Details { get; set; }
        public IList<AppointmentApproval>? AppointmentApproval { get; set; }
        public IList<Invoice_Master>? Invoice_Master { get; set; }
        public IList<Invoice_Details_Product>? Invoice_Details_Product { get; set; }

    }
}
