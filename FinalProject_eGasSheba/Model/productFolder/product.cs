using FinalProject_eGasSheba.Model.child;
using FinalProject_eGasSheba.Model.puechase;
using FinalProject_eGasSheba.Model.sales;
using FinalProject_eGasSheba.Model.services;
using FinalProject_eGasSheba.Model.stock;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinalProject_eGasSheba.Model.child
{

    public partial class product
    {

        public product()
        {
            appointmentApproveds = new HashSet<AppointmentApproval>();
            cylinderReturns = new HashSet<cylinderReturn>();
            InvoiceDetailsProducts = new HashSet<InvoiceDetailsProduct>();
            purchaseDetails = new HashSet<purchaseDetail>();
            purchaseOrderDetalis = new HashSet<purchaseOrderDetali>();
            salesDetails = new HashSet<salesDetail>();
            stocks = new HashSet<stock.stock>();
        }
        [Key]
        public int proID { get; set; }
        public string proName { get; set; }
        [ForeignKey("Distributor")]
        public int DistributorID { get; set; }
        [ForeignKey("Dept")]
        public int? depID { get; set; }
        public string proDetail { get; set; }
        [ForeignKey("Type")]
        public int? proType { get; set; }
        public decimal? size { get; set; }
        [ForeignKey("Weight")]
        public int? proWeight { get; set; }
        public string proImage { get; set; }
        public decimal? price { get; set; }

        public virtual ICollection<AppointmentApproval>? appointmentApproveds { get; set; }
        public virtual ICollection<cylinderReturn>? cylinderReturns { get; set; }
        public virtual Dept Dept { get; set; }
        public virtual Distributor Distributor { get; set; }
        public virtual ICollection<InvoiceDetailsProduct>? InvoiceDetailsProducts { get; set; }
        public virtual child.Type Type { get; set; }
        public virtual Weight Weight { get; set; }
        public virtual ICollection<purchaseDetail>? purchaseDetails { get; set; }
        public virtual ICollection<purchaseOrderDetali>? purchaseOrderDetalis { get; set; }
        public virtual ICollection<salesDetail>? salesDetails { get; set; }
        public virtual ICollection<stock.stock>? stocks { get; set; }
    }
}
