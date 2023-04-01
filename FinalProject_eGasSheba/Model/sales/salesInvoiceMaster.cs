using FinalProject_eGasSheba.Model.accounts;
using FinalProject_eGasSheba.Model.child;
using FinalProject_eGasSheba.Model.stock;
using FinalProject_eGasSheba.Model.technician_Delivary;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinalProject_eGasSheba.Model.sales
{
    public partial class salesInvoiceMaster
    {
        
        public salesInvoiceMaster()
        {
            this.cylinderReturns = new HashSet<cylinderReturn>();
            this.InvoiceDetailsProducts = new HashSet<InvoiceDetailsProduct>();
            this.InvoiceReceivedDetails = new HashSet<InvoiceReceivedDetail>();
            this.journals = new HashSet<journal>();
        }
        [Key]
        public string invoiceMasterID { get; set; }
        [ForeignKey("salesMaster")]
        public string salesMasterID { get; set; }
        public Nullable<System.DateTime> date_time { get; set; }
        public string cutomerName { get; set; }
        public string phone { get; set; }
        [ForeignKey("City")]
        public int cityID { get; set; }
        [ForeignKey("Area")]
        public int areaID { get; set; }
        public string road_No { get; set; }
        public string house_No { get; set; }
        public string floorNo { get; set; }
        public Nullable<decimal> Total { get; set; }
        public Nullable<decimal> delivaryCost { get; set; }
        public Nullable<decimal> gross { get; set; }
        public Nullable<decimal> discount { get; set; }
        public Nullable<decimal> netAmount { get; set; }
        public Nullable<decimal> paid { get; set; }
        public Nullable<decimal> due { get; set; }
        public Nullable<decimal> totalAmount { get; set; }
        [ForeignKey("payment_type")]
        public Nullable<int> paymentID { get; set; }
        [ForeignKey("deliveryMan")]
        public Nullable<int> deliveryManID { get; set; }

        public virtual Area Area { get; set; }
        public virtual City City { get; set; }
        
        public virtual ICollection<cylinderReturn>? cylinderReturns { get; set; }
        public virtual deliveryMan deliveryMan { get; set; }
        
        public virtual ICollection<InvoiceDetailsProduct>? InvoiceDetailsProducts { get; set; }
        public virtual ICollection<InvoiceReceivedDetail>? InvoiceReceivedDetails { get; set; }
        public virtual ICollection<journal>? journals { get; set; }
        public virtual payment_type payment_type { get; set; }
        public virtual salesMaster salesMaster { get; set; }
    }
}
