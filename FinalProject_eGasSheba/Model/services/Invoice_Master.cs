using FinalProject_eGasSheba.Model.child;
using FinalProject_eGasSheba.Model.sales;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using FinalProject_eGasSheba.Model.technician_Delivary;

namespace FinalProject_eGasSheba.Model.services
{
    public class Invoice_Master
    {
        [Key]
        public string InvoiceMaster_ID { get; set; }
        [ForeignKey("AppointmentApproval")]
        public string Approval_ID { get; set; }
        public DateTime Date { get; set; }
        public string Customer_Name { get; set; }
        public string Phone { get; set; }
        [ForeignKey("City")]
        public int City_ID { get; set; }
        [ForeignKey("Area")]
        public int Area_ID { get; set; }
        public string Road_ID { get; set; }
        public string House_No { get; set; }
        public string Floor_NO { get; set; }
        [ForeignKey("Delivery")]
        public string DelivaryMan_ID { get; set; }
        [ForeignKey("PaymentTypes")]
        public int Payment_ID { get; set; }
        public Double Price { get; set; }
        [ForeignKey("technician")]
        public int Technician_ID { get; set; }
        public payment_type PaymentTypes { get; set; }
        public deliveryMan DeliveryMan { get; set; }
        public Area Area { get; set; }
        public technician Technician { get; set; }
        public City City { get; set; }
        public IList<Invoice_Details_Product>? Invoice_Details_Product { get; set; }

    }
}
